namespace NewsReader
{
    partial class Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reader));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_saveSitting = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chk_Startup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_updatetime = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.⁄‰«·»—‰«„ÃToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.√⁄œ«œ« «·»—‰«„ÃToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.√Œ»—’œÌﬁToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.√€·«ﬁToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_updatetime)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_hide);
            this.groupBox1.Controls.Add(this.btn_saveSitting);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.chk_Startup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_updatetime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(359, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "≈⁄œ«œ«  «·»—‰«„Ã";
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(6, 139);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(80, 27);
            this.btn_hide.TabIndex = 8;
            this.btn_hide.Text = "≈Œ›«¡";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_saveSitting
            // 
            this.btn_saveSitting.Location = new System.Drawing.Point(104, 139);
            this.btn_saveSitting.Name = "btn_saveSitting";
            this.btn_saveSitting.Size = new System.Drawing.Size(245, 27);
            this.btn_saveSitting.TabIndex = 7;
            this.btn_saveSitting.Text = "Õ›Ÿ «·≈⁄œ«œ« ";
            this.btn_saveSitting.UseVisualStyleBackColor = true;
            this.btn_saveSitting.Click += new System.EventHandler(this.btn_saveSitting_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(278, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 21);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "√Œ»— ’œÌﬁ.";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chk_Startup
            // 
            this.chk_Startup.AutoSize = true;
            this.chk_Startup.Location = new System.Drawing.Point(99, 70);
            this.chk_Startup.Name = "chk_Startup";
            this.chk_Startup.Size = new System.Drawing.Size(250, 21);
            this.chk_Startup.TabIndex = 5;
            this.chk_Startup.Text = " ‘€· «·»—‰«„Ã  ·ﬁ«∆Ì« ⁄‰œ »œ¡ «· ‘€Ì·.";
            this.chk_Startup.UseVisualStyleBackColor = true;
            this.chk_Startup.CheckedChanged += new System.EventHandler(this.chk_Startup_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "“„‰  ÕœÌÀ «·√Œ»«— »«·œﬁ«∆ﬁ : ";
            // 
            // num_updatetime
            // 
            this.num_updatetime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_updatetime.Location = new System.Drawing.Point(113, 28);
            this.num_updatetime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_updatetime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_updatetime.Name = "num_updatetime";
            this.num_updatetime.Size = new System.Drawing.Size(56, 24);
            this.num_updatetime.TabIndex = 3;
            this.num_updatetime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_updatetime.ValueChanged += new System.EventHandler(this.num_updatetime_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Ì„ﬂ‰ﬂ «·÷€ÿ ⁄·Ï «·«ÌﬁÊ‰… \r\n·√ŸÂ«— ŒÌ«—«  «·»—‰«„Ã\r\n";
            this.notifyIcon1.BalloonTipTitle = "»—‰«„Ã ﬁ«—∆ «·«Œ»«—";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "»—‰«„Ã ﬁ«—∆ «·√Œ»«—";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem,
            this.⁄‰«·»—‰«„ÃToolStripMenuItem,
            this.√⁄œ«œ« «·»—‰«„ÃToolStripMenuItem,
            this.√Œ»—’œÌﬁToolStripMenuItem,
            this.√€·«ﬁToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 114);
            // 
            // ⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem
            // 
            this.⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem.Name = "⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem";
            this.⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem.Text = "⁄—÷ √ÕœÀ Œ„” ⁄‰«ÊÌ‰";
            this.⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem.Click += new System.EventHandler(this.⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem_Click);
            // 
            // ⁄‰«·»—‰«„ÃToolStripMenuItem
            // 
            this.⁄‰«·»—‰«„ÃToolStripMenuItem.Name = "⁄‰«·»—‰«„ÃToolStripMenuItem";
            this.⁄‰«·»—‰«„ÃToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.⁄‰«·»—‰«„ÃToolStripMenuItem.Text = "⁄‰ «·»—‰«„Ã";
            this.⁄‰«·»—‰«„ÃToolStripMenuItem.Click += new System.EventHandler(this.⁄‰«·»—‰«„ÃToolStripMenuItem_Click);
            // 
            // √⁄œ«œ« «·»—‰«„ÃToolStripMenuItem
            // 
            this.√⁄œ«œ« «·»—‰«„ÃToolStripMenuItem.Name = "√⁄œ«œ« «·»—‰«„ÃToolStripMenuItem";
            this.√⁄œ«œ« «·»—‰«„ÃToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.√⁄œ«œ« «·»—‰«„ÃToolStripMenuItem.Text = "√⁄œ«œ«  «·»—‰«„Ã";
            this.√⁄œ«œ« «·»—‰«„ÃToolStripMenuItem.Click += new System.EventHandler(this.√⁄œ«œ« «·»—‰«„ÃToolStripMenuItem_Click);
            // 
            // √Œ»—’œÌﬁToolStripMenuItem
            // 
            this.√Œ»—’œÌﬁToolStripMenuItem.Name = "√Œ»—’œÌﬁToolStripMenuItem";
            this.√Œ»—’œÌﬁToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.√Œ»—’œÌﬁToolStripMenuItem.Text = "√Œ»— ’œÌﬁ";
            this.√Œ»—’œÌﬁToolStripMenuItem.Click += new System.EventHandler(this.√Œ»—’œÌﬁToolStripMenuItem_Click);
            // 
            // √€·«ﬁToolStripMenuItem
            // 
            this.√€·«ﬁToolStripMenuItem.Name = "√€·«ﬁToolStripMenuItem";
            this.√€·«ﬁToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.√€·«ﬁToolStripMenuItem.Text = "√€·«ﬁ";
            this.√€·«ﬁToolStripMenuItem.Click += new System.EventHandler(this.√€·«ﬁToolStripMenuItem_Click);
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 203);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reader";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ﬁ«—∆ «·«Œ»«—";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reader_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_updatetime)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_updatetime;
        private System.Windows.Forms.CheckBox chk_Startup;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_saveSitting;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ⁄‰«·»—‰«„ÃToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem √⁄œ«œ« «·»—‰«„ÃToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem √Œ»—’œÌﬁToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem √€·«ﬁToolStripMenuItem;

    }
}

