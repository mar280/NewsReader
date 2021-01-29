using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace NewsReader
{
    public partial class NewsForm : Form
    {
        News news;
        System.Windows.Forms.Timer show;
        System.Windows.Forms.Timer hide;
        System.Windows.Forms.Timer stay;
        int xLocation;
        int yLocation;
        int showHeight;
        int stat;
        public NewsForm(News n,int count)
        {
            InitializeComponent();
            this.Parent = null;
            news = n;
            lbt_newsData.Text = news.Name;
            lbt_newsDate.Text = news.day+ " : "+ news.Date;
            xLocation = Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width-20;
            yLocation = Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height * count-20;
            if (count != 0)
            {
                yLocation = yLocation - 20 * count;
            }
            showHeight = 0;
            this.Location = new Point(xLocation, yLocation);
            show = new System.Windows.Forms.Timer();
            show.Interval = 10;
            show.Tick += new EventHandler(show_Tick);
            show.Start();
            hide = new System.Windows.Forms.Timer();
            hide.Interval = 10;
            hide.Tick += new EventHandler(hide_Tick);
            stay = new System.Windows.Forms.Timer();
            stay.Interval = 5000;
            stay.Tick += new EventHandler(stay_Tick);
            this.TopMost = true;
            stat = 0;
        }

        void stay_Tick(object sender, EventArgs e)
        {
            stay.Stop();
            hide.Start();
            stat = 2;
            this.TopMost = false;
            
        }

        void hide_Tick(object sender, EventArgs e)
        {
            showHeight--;
            if (showHeight <= -(Screen.PrimaryScreen.WorkingArea.Height/2))
            {
                hide.Stop();
                this.Close();
                return;
            }
            this.Location = new Point(xLocation, yLocation - showHeight);

        }

        void show_Tick(object sender, EventArgs e)
        {
            showHeight++;
            if (showHeight >= this.Size.Height)
            {
                show.Stop();
                stay.Start();
                stat = 1;
                return;
            }
            this.Location = new Point(xLocation, yLocation - showHeight);
        }

        private void link_detail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(news.Detail);
            }
            catch { }
        }


        private void NewsForm_MouseEnter(object sender, EventArgs e)
        {
            if (stat == 2)
            {
                hide.Stop();
            }
            if (stat == 1)
            {
                stay.Stop();
            }
        }

        private void NewsForm_MouseLeave(object sender, EventArgs e)
        {

            if (stat == 2)
            {
                hide.Start();
            }
            if (stat == 1)
            {
                stay.Start();
            }
        }

        private void lbt_newsData_MouseEnter(object sender, EventArgs e)
        {
            if (stat == 2)
            {
                hide.Stop();
            }
            if (stat == 1)
            {
                stay.Stop();
            }
        }

        private void lbt_newsDate_MouseEnter(object sender, EventArgs e)
        {
            if (stat == 2)
            {
                hide.Stop();
            }
            if (stat == 1)
            {
                stay.Stop();
            }
        }

        private void link_detail_MouseEnter(object sender, EventArgs e)
        {
            if (stat == 2)
            {
                hide.Stop();
            }
            if (stat == 1)
            {
                stay.Stop();
            }
        }

    }
}