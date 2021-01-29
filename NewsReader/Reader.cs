using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Management;
using System.Net;

namespace NewsReader
{
    public partial class Reader : Form
    {
        String xml_source;
        int updateTime;
        bool startup;
        String tellFriend;
        String aboutUs;
        ReadXML readXml;
        Timer updateTimer;
        int last_id;
        bool from_x;
        ManagementObjectSearcher searcher;
        public static String cpuId;
        int countOfConnection;

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState( out int Description, int ReservedValue ) ;
        private static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } 

        public Reader()
        {
            InitializeComponent();
            LoadProperties();
            searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            ManagementObjectCollection collection = searcher.Get();
            foreach (ManagementObject mangObject in collection)
            {
                cpuId = (String)mangObject["ProcessorId"];
            }
            updateTimer = new Timer();
            updateTimer.Tick += new EventHandler(updateTimer_Tick);
            updateTimer.Interval = updateTime * 60000;
            updateTimer.Start();
            this.Opacity = 0;
        }

        void updateTimer_Tick(object sender, EventArgs e)
        {
            if (!IsConnectedToInternet())
            {
                return;
            }
            try
            {
                readXml.reset();
                readXml = new ReadXML(xml_source);
                for (int i = 0; i < 5 && i<readXml.newsList.Count; i++)
                {
                    if (readXml.newsList[i].id_sort > last_id)
                    {
                        NewsForm f = new NewsForm(readXml.newsList[i], i);
                        f.Show();
                    }
                }
                last_id = readXml.newsList[0].id_sort;
            }
            catch(Exception ex)
            {
            }
        }

        private void LoadProperties()
        {
            try
            {
                xml_source = StaticData.xmlFile;
                tellFriend = StaticData.tellFrind;
                aboutUs = StaticData.aboutUs;
                updateTime = 5;
                num_updatetime.Value = updateTime;
                startup = isOnStartUp();
                chk_Startup.Checked = startup;
                RunStartup(startup);
                btn_saveSitting.Enabled = false;
                last_id = -1;
                from_x = true;
                countOfConnection = 0;
            }
            catch
            {
                MessageBox.Show("Œÿ√ ›Ì  Õ„Ì· «·«⁄œ«œ« ", "Œÿ√", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (!IsConnectedToInternet())
                {
                    return;
                }
                readXml = new ReadXML(xml_source);
            }
            catch
            {
                MessageBox.Show("Œÿ√ ›Ì  Õ„Ì· „·› «·«Œ»«—", "Œÿ√", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(tellFriend);
        }

        private void chk_editSource_CheckedChanged(object sender, EventArgs e)
        {
            btn_saveSitting.Enabled = true;
        }

        private void num_updatetime_ValueChanged(object sender, EventArgs e)
        {
            updateTime = int.Parse(num_updatetime.Value.ToString());
            btn_saveSitting.Enabled = true;
        }

        private void chk_Startup_CheckedChanged(object sender, EventArgs e)
        {
            startup = chk_Startup.Checked;
            RunStartup(startup);
            isOnStartUp();
            btn_saveSitting.Enabled = true;
        }



        private void RunStartup(Boolean RunOnStartup)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (RunOnStartup == true)
            {
                key.SetValue("NewsReader", Application.ExecutablePath.ToString());
            }
            else
            {
                key.SetValue("NewsReader", "");
            }
        }
        private bool isOnStartUp()
        {
            bool result = false;
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            Object o = key.GetValue("NewsReader");
            String keyvalue = Convert.ToString(o);
            if (keyvalue.Equals("new"))
                result = true;
            return result;
        }

        private void btn_saveSitting_Click(object sender, EventArgs e)
        {
            //xml_source = txt_url.Text;
            try
            {
                RunStartup(startup);
            }
            catch(Exception ee)
            {
                MessageBox.Show("Œÿ√ ›Ì Õ›Ÿ «·«⁄œ«œ« ", "Œÿ√", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btn_saveSitting.Enabled = false;
            MessageBox.Show(" „ Õ›Ÿ «·«⁄œ«œ«  »‰Ã«Õ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            ShowInTaskbar = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = false;
            this.Opacity = 1;
            this.BringToFront();
            this.TopMost = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon1.BalloonTipText = "Connected Users = " + ReadXML.connection;
                notifyIcon1.ShowBalloonTip(3000);
            }
        }
        private void √€·«ﬁToolStripMenuItem_Click(object sender, EventArgs e)
        {
            from_x = false;
            this.Close();
        }

        private void √⁄œ«œ« «·»—‰«„ÃToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.TopMost = true;
            ShowInTaskbar = true;
        }

        private void ⁄‰«·»—‰«„ÃToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(aboutUs);
        }

        private void √Œ»—’œÌﬁToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(tellFriend);
        }

        private void ⁄—÷√ÕœÀŒ„”⁄‰«ÊÌ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    NewsForm f = new NewsForm(readXml.newsList[i], i);
                    f.Show();
                }
            }
            catch { }
        }

        private void Reader_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            WebRequest request = WebRequest.Create(StaticData.feedback + cpuId + "=xxx");
            request.Method = "Get";
            WebResponse responce= request.GetResponse();
            Stream s= responce.GetResponseStream();
            TextReader txtreader = new StreamReader(s);
            Console.WriteLine(txtreader.ReadLine());
        }

     


      


    }
}