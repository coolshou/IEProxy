using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace IEProxy
{
    class Logic
    {
        private RegistryKey software = Registry.LocalMachine.OpenSubKey(@"SOFTWARE", true);
        private RegistryKey manProxy, autoConfig, ieProxy;
        
        public Logic()
        {
            ieProxy = software.OpenSubKey(@"IEProxy", true);

            if (ieProxy == null)
            {
                software.CreateSubKey("IEProxy");
            }


            ieProxy = software.OpenSubKey(@"IEProxy", true);
            autoConfig = ieProxy.OpenSubKey("AutoConfigProxies", true);
            manProxy = ieProxy.OpenSubKey("ManualProxies", true);

            if (autoConfig == null)
            {
                ieProxy.CreateSubKey("AutoConfigProxies");
                autoConfig = ieProxy.OpenSubKey("AutoConfigProxies", true);
            }
            if (manProxy == null)
            {
                ieProxy.CreateSubKey("ManualProxies");
                manProxy = ieProxy.OpenSubKey("ManualProxies", true);
            }

        }

        
        public void switchAutoDetectProxy()
        {
            WinInetInterop.SetInternetProxy(WinInetInterop.IsUseProxy(), WinInetInterop.GetProxyServerURL(), "", !WinInetInterop.IsAutoDetectProxy(),
                                            WinInetInterop.IsAutoConfigProxy(), WinInetInterop.GetAutoConfigURL());
        }

    

        public bool isAutostart()
        {
            object regvalue = Registry.GetValue(@"HKEY_Current_User\SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                                                "IEProxy", null);
            if (regvalue != null)
            {
                return true;
            }

            return false;
        }


        public void setAutostart(bool isChecked, string path)
        {
            RegistryKey autostart = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (autostart != null)
            {
                if (isChecked)
                {
                    autostart.SetValue("IEProxy", path, RegistryValueKind.String);
                }
                else
                {
                    autostart.DeleteValue("IEProxy");
                }
            }
            else
            {
                MessageBox.Show("Can't access the Startup Entries in your Registry", "Registry Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public bool proxiesSaved()
        {
            if (software != null)
            {
                return (manProxy.GetValueNames().Length) + autoConfig.GetValueNames().Length > 0;
            }
            else
            {
                MessageBox.Show("Can't access the Startup Entries in your Registry", "Registry Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            return false;
            
        }

        public void addProxy(string name, string url, string port, bool isChecked)
        {

            if (isChecked)
            {
                autoConfig.SetValue(name,url,RegistryValueKind.String);
            }
            else
            {
                manProxy.SetValue(name, url + ":" + port);
            }

        }

        public Collection<proxyEntry> getAllProxies()
        {
            Collection<proxyEntry> retCollection = new Collection<proxyEntry>();
            
 
            foreach (string key in autoConfig.GetValueNames())
            {

                retCollection.Add(new proxyEntry(key + " (AutoConfig)", (string)autoConfig.GetValue(key, "")));
            }

            foreach (string key in manProxy.GetValueNames())
            {

                retCollection.Add(new proxyEntry(key + " (Proxy)", (string)manProxy.GetValue(key, "")));
            }

            return retCollection;
        }

        public void deleteProxy(string name)
        {
            string deleteVal = name.Remove(name.LastIndexOf(" "));

            if (name.EndsWith(" (Proxy)"))
            {
                manProxy.DeleteValue(deleteVal);
            }
            else
            {
                autoConfig.DeleteValue(deleteVal);
            }
        }

        public void setProxy(string text)
        {
            text = text.Remove(text.LastIndexOf(" "));
            WinInetInterop.SetInternetProxy(true, (string) manProxy.GetValue(text, ""), "",
                                            WinInetInterop.IsAutoDetectProxy(), false,
                                            WinInetInterop.GetAutoConfigURL());  
        }

        public void setAutoConfig(string text)
        {
            text = text.Remove(text.LastIndexOf(" "));
            WinInetInterop.SetInternetProxy(false, WinInetInterop.GetProxyServerURL(), "",
                                            WinInetInterop.IsAutoDetectProxy(), true, (string)autoConfig.GetValue(text, ""));
        }

        public void disableProxy()
        {
            WinInetInterop.SetInternetProxy(false, WinInetInterop.GetProxyServerURL(), "",
                                            WinInetInterop.IsAutoDetectProxy(), WinInetInterop.IsAutoConfigProxy(), WinInetInterop.GetAutoConfigURL());
        }

        public void disableAutoConfig()
        {
            WinInetInterop.SetInternetProxy(WinInetInterop.IsUseProxy(), WinInetInterop.GetProxyServerURL(), "",
                                            WinInetInterop.IsAutoDetectProxy(), false, WinInetInterop.GetAutoConfigURL());
        }
    }
}
