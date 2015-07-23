namespace IEProxy
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableProxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autostartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setProxyToolStripMenuItem,
            this.addProxyToolStripMenuItem,
            this.deleteProxyToolStripMenuItem,
            this.disableProxiesToolStripMenuItem,
            this.autoDetectToolStripMenuItem,
            this.toolStripSeparator1,
            this.autostartToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(173, 192);
            // 
            // setProxyToolStripMenuItem
            // 
            this.setProxyToolStripMenuItem.Name = "setProxyToolStripMenuItem";
            this.setProxyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.setProxyToolStripMenuItem.Text = "Set Proxy";
            this.setProxyToolStripMenuItem.Visible = false;
            // 
            // addProxyToolStripMenuItem
            // 
            this.addProxyToolStripMenuItem.Name = "addProxyToolStripMenuItem";
            this.addProxyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addProxyToolStripMenuItem.Text = "Add Proxy";
            this.addProxyToolStripMenuItem.Click += new System.EventHandler(this.addProxyToolStripMenuItem_Click);
            // 
            // deleteProxyToolStripMenuItem
            // 
            this.deleteProxyToolStripMenuItem.Name = "deleteProxyToolStripMenuItem";
            this.deleteProxyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteProxyToolStripMenuItem.Text = "Delete Proxy";
            this.deleteProxyToolStripMenuItem.Visible = false;
            this.deleteProxyToolStripMenuItem.Click += new System.EventHandler(this.deleteProxyToolStripMenuItem_Click);
            // 
            // disableProxiesToolStripMenuItem
            // 
            this.disableProxiesToolStripMenuItem.Name = "disableProxiesToolStripMenuItem";
            this.disableProxiesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.disableProxiesToolStripMenuItem.Text = "Disable Proxies";
            this.disableProxiesToolStripMenuItem.Click += new System.EventHandler(this.disableProxiesToolStripMenuItem_Click);
            // 
            // autoDetectToolStripMenuItem
            // 
            this.autoDetectToolStripMenuItem.Name = "autoDetectToolStripMenuItem";
            this.autoDetectToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.autoDetectToolStripMenuItem.Text = "Auto Detect";
            this.autoDetectToolStripMenuItem.Click += new System.EventHandler(this.autoDetectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // autostartToolStripMenuItem
            // 
            this.autostartToolStripMenuItem.CheckOnClick = true;
            this.autostartToolStripMenuItem.Name = "autostartToolStripMenuItem";
            this.autostartToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.autostartToolStripMenuItem.Text = "Autorun at Startup";
            this.autostartToolStripMenuItem.Click += new System.EventHandler(this.autostartToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(216, 89);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Add";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(297, 89);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proxy URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(105, 51);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(168, 20);
            this.urlTextBox.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(297, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "AutoConfig";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(105, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(311, 51);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(44, 20);
            this.portTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // mainForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.portTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 160);
            this.MinimumSize = new System.Drawing.Size(400, 160);
            this.Name = "mainForm";
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Proxy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addProxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem autostartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem disableProxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setProxyToolStripMenuItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem deleteProxyToolStripMenuItem;

    }
}

