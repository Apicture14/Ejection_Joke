namespace usbTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TP = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.RT = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CB_S = new System.Windows.Forms.CheckBox();
            this.LB = new System.Windows.Forms.ListBox();
            this.BtD = new System.Windows.Forms.Button();
            this.BtA = new System.Windows.Forms.Button();
            this.Vin = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.TP.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "EJ";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.showToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(83, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // TP
            // 
            this.TP.Controls.Add(this.tabPage1);
            this.TP.Controls.Add(this.tabPage2);
            this.TP.Location = new System.Drawing.Point(3, 3);
            this.TP.Name = "TP";
            this.TP.SelectedIndex = 0;
            this.TP.Size = new System.Drawing.Size(338, 206);
            this.TP.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.RT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RT
            // 
            this.RT.Location = new System.Drawing.Point(6, 6);
            this.RT.Name = "RT";
            this.RT.ReadOnly = true;
            this.RT.Size = new System.Drawing.Size(317, 140);
            this.RT.TabIndex = 3;
            this.RT.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtS);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.CB_S);
            this.tabPage2.Controls.Add(this.LB);
            this.tabPage2.Controls.Add(this.BtD);
            this.tabPage2.Controls.Add(this.BtA);
            this.tabPage2.Controls.Add(this.Vin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtS
            // 
            this.BtS.Location = new System.Drawing.Point(195, 75);
            this.BtS.Name = "BtS";
            this.BtS.Size = new System.Drawing.Size(79, 23);
            this.BtS.TabIndex = 6;
            this.BtS.Text = "SaveLog";
            this.BtS.UseVisualStyleBackColor = true;
            this.BtS.Click += new System.EventHandler(this.BtS_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 21);
            this.textBox1.TabIndex = 5;
            // 
            // CB_S
            // 
            this.CB_S.AutoSize = true;
            this.CB_S.Location = new System.Drawing.Point(194, 114);
            this.CB_S.Name = "CB_S";
            this.CB_S.Size = new System.Drawing.Size(90, 16);
            this.CB_S.TabIndex = 4;
            this.CB_S.Text = "AutoSaveLog";
            this.CB_S.UseVisualStyleBackColor = true;
            // 
            // LB
            // 
            this.LB.FormattingEnabled = true;
            this.LB.ItemHeight = 12;
            this.LB.Location = new System.Drawing.Point(11, 41);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(177, 124);
            this.LB.TabIndex = 3;
            // 
            // BtD
            // 
            this.BtD.Location = new System.Drawing.Point(195, 41);
            this.BtD.Name = "BtD";
            this.BtD.Size = new System.Drawing.Size(66, 19);
            this.BtD.TabIndex = 2;
            this.BtD.Text = "Remove";
            this.BtD.UseVisualStyleBackColor = true;
            this.BtD.Click += new System.EventHandler(this.BtD_Click);
            // 
            // BtA
            // 
            this.BtA.Location = new System.Drawing.Point(195, 8);
            this.BtA.Name = "BtA";
            this.BtA.Size = new System.Drawing.Size(66, 19);
            this.BtA.TabIndex = 1;
            this.BtA.Text = "Add";
            this.BtA.UseVisualStyleBackColor = true;
            this.BtA.Click += new System.EventHandler(this.BtA_Click);
            // 
            // Vin
            // 
            this.Vin.Location = new System.Drawing.Point(6, 6);
            this.Vin.Name = "Vin";
            this.Vin.Size = new System.Drawing.Size(183, 21);
            this.Vin.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 221);
            this.Controls.Add(this.TP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Usb";
            this.contextMenuStrip1.ResumeLayout(false);
            this.TP.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.TabControl TP;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RT;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox LB;
        private System.Windows.Forms.Button BtD;
        private System.Windows.Forms.Button BtA;
        private System.Windows.Forms.TextBox Vin;
        private System.Windows.Forms.Button BtS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CB_S;
    }
}