using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace IEProxy
{
    public partial class mainForm : Form
    {
        private AboutBox1 about;
        private Logic logic;
        
        public mainForm()
        {
            InitializeComponent();

            logic = new Logic();

            
            autostartToolStripMenuItem.Checked = logic.isAutostart();

            testForProxies();
            
        }

        private void testForProxies()
        {
            autoDetectToolStripMenuItem.Checked = WinInetInterop.IsAutoDetectProxy();
            disableProxiesToolStripMenuItem.Checked = !WinInetInterop.IsAnyProxy();

            if (logic.proxiesSaved())
            {
                setProxyToolStripMenuItem.Visible = true;
                deleteProxyToolStripMenuItem.Visible = true;
                fillProxyItem();
            }
            else
            {
                deleteProxyToolStripMenuItem.Visible = false;
                setProxyToolStripMenuItem.DropDownItems.Clear();
                setProxyToolStripMenuItem.Visible = false;
            }
        }

        private void fillProxyItem()
        {
            setProxyToolStripMenuItem.DropDownItems.Clear();
            Collection<proxyEntry> proxies = logic.getAllProxies();
            
            foreach (proxyEntry entry in proxies)
            {
                ToolStripMenuItem temp = new ToolStripMenuItem(entry.key);
                
                if (((WinInetInterop.GetAutoConfigURL() == entry.url || WinInetInterop.GetAutoConfigURL() == entry.url + "/") && WinInetInterop.IsAutoConfigProxy())
                    || (WinInetInterop.GetProxyServerURL() == entry.url ||  WinInetInterop.GetProxyServerURL() == entry.url +":80") && WinInetInterop.IsUseProxy())
                {
                    temp.Checked = true;
                }
                if (entry.key.EndsWith(" (Proxy)"))
                {
                    temp.Click += new EventHandler(proxyItem_Click);
                }
                else
                {
                    temp.Click += new EventHandler(autoConfigItem_Click);
                }
                setProxyToolStripMenuItem.DropDownItems.Add(temp);
            } 
        }

        private void autoConfigItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked)
            {
                logic.disableAutoConfig();
            }
            else
            {
                logic.setAutoConfig(((ToolStripMenuItem) sender).Text);
                
            }
            foreach (ToolStripMenuItem item in setProxyToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }

            testForProxies();
        }

        private void proxyItem_Click(object sender, EventArgs e)
        {

            if (((ToolStripMenuItem)sender).Checked)
            {
                logic.disableProxy();
            }
            else
            {
                logic.setProxy(((ToolStripMenuItem)sender).Text);
            }

            foreach (ToolStripMenuItem item in setProxyToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
            
            

            testForProxies();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(about == null)
            {
                about = new AboutBox1();
            }
            about.ShowDialog();
        }

        private void autostartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            logic.setAutostart(autostartToolStripMenuItem.Checked, Application.ExecutablePath);
            
        }

       private void autoDetectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            logic.switchAutoDetectProxy();
           testForProxies();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked)
            {
                label1.Text = "AutoConfig URL";
                portTextBox.Enabled = false;
            }
            else
            {
                label1.Text = "Proxy URL";
                portTextBox.Enabled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Opacity = 0;
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (urlTextBox.Text == "" || nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a Proxy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                logic.addProxy(nameTextBox.Text,urlTextBox.Text,portTextBox.Text, checkBox1.Checked);
                nameTextBox.Text = "";
                urlTextBox.Text = "";
                portTextBox.Text = "";
                checkBox1.Checked = false;
                MessageBox.Show("Proxy added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
                nameTextBox.Focus();
                testForProxies();
                
            }
            
        }

        private void addProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urlTextBox.Text = "";
            nameTextBox.Text = "";
            portTextBox.Text = "";
            checkBox1.Checked = false;
            nameTextBox.Focus();
            ShowInTaskbar = true;
            Opacity = 1;
            
        }

        private void disableProxiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            WinInetInterop.SetInternetProxy(false, WinInetInterop.GetProxyServerURL(), "", false, false,
                                            WinInetInterop.GetAutoConfigURL());
            testForProxies();    
            
        }

        

        private void deleteProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DeleteForm df = new DeleteForm();
            df.ShowDialog(this);
            df.Dispose();

            testForProxies();
        }


        //disable X Button and ALT+F4
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg != 0x0010)
            {
                base.WndProc(ref m);
            }
            else
            {
                //Windows has send the WM_CLOSE message to your form.
                //Ignore this message will make the window stay open.
            }
        }


       


    }
}
