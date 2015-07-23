using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IEProxy
{
    public partial class DeleteForm : Form
    {
        Logic logic = new Logic();

        public DeleteForm()
        {
            InitializeComponent();

            fillDrop();
        }

        private void fillDrop()
        {
            comboBox.Items.Clear();
            Collection<proxyEntry> proxies = logic.getAllProxies();

            foreach (proxyEntry entry in proxies)
            {
                comboBox.Items.Add(entry.key);
            }

            if (comboBox.Items.Count == 0)
            {
                comboBox.Items.Add("no Proxy saved");
                deleteButton.Enabled = false;
            }

            comboBox.SelectedIndex = 0;
            comboBox.Focus();    
            
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            logic.deleteProxy(comboBox.SelectedItem.ToString());
            label2.Text = comboBox.SelectedItem.ToString() + " deleted...";
            fillDrop();
            
        }
    }
}
