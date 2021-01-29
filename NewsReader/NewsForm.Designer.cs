namespace NewsReader
{
    partial class NewsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsForm));
            this.link_detail = new System.Windows.Forms.LinkLabel();
            this.lbt_newsDate = new System.Windows.Forms.Label();
            this.lbt_newsData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // link_detail
            // 
            resources.ApplyResources(this.link_detail, "link_detail");
            this.link_detail.Name = "link_detail";
            this.link_detail.TabStop = true;
            this.link_detail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_detail_LinkClicked);
            this.link_detail.MouseEnter += new System.EventHandler(this.link_detail_MouseEnter);
            // 
            // lbt_newsDate
            // 
            resources.ApplyResources(this.lbt_newsDate, "lbt_newsDate");
            this.lbt_newsDate.Name = "lbt_newsDate";
            this.lbt_newsDate.MouseEnter += new System.EventHandler(this.lbt_newsDate_MouseEnter);
            // 
            // lbt_newsData
            // 
            resources.ApplyResources(this.lbt_newsData, "lbt_newsData");
            this.lbt_newsData.Name = "lbt_newsData";
            this.lbt_newsData.ReadOnly = true;
            this.lbt_newsData.MouseEnter += new System.EventHandler(this.lbt_newsData_MouseEnter);
            // 
            // NewsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbt_newsData);
            this.Controls.Add(this.lbt_newsDate);
            this.Controls.Add(this.link_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MouseEnter += new System.EventHandler(this.NewsForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NewsForm_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_detail;
        private System.Windows.Forms.Label lbt_newsDate;
        private System.Windows.Forms.TextBox lbt_newsData;
    }
}