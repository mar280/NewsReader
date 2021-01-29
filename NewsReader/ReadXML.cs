using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace NewsReader
{
    class ReadXML
    {
        XmlTextReader rssReader;
        XmlDocument rssDoc;
        XmlNode nodeRss;
        XmlNode newsNode;
        public List<News> newsList;
        WebRequest request;
        static public string connection = "UnKnown";
        public ReadXML(string xmlurl)
        {
            try
            {
                request = WebRequest.Create(StaticData.feedback + Reader.cpuId + "=" + Reader.cpuId);
                request.Method = "Get";

                WebResponse responce = request.GetResponse();
                Stream ss = responce.GetResponseStream();
                TextReader txtreader = new StreamReader(ss);
                connection = txtreader.ReadLine();

                WebClient Client = new WebClient();
                Client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                Client.DownloadFile(xmlurl,"data.xml");
                Stream s = Client.OpenRead(xmlurl);
                rssReader = new XmlTextReader(s);
                rssDoc = new XmlDocument();
                newsList = new List<News>();
                // Load the XML content into a XmlDocument
                
                rssDoc.Load(rssReader);
                // Get the <Newfeed> tag
                for (int i = 0; i < rssDoc.ChildNodes.Count; i++)
                {
                    // If it is the Newfeed tag
                    if (rssDoc.ChildNodes[i].Name == "Newfeed")
                    {
                        // <Newfeed> tag found
                        nodeRss = rssDoc.ChildNodes[i];
                        break;
                    }
                }
                // Loop for the <news> tag
                for (int i = 0; i < nodeRss.ChildNodes.Count; i++)
                {
                    // If it is the news tag
                    if (nodeRss.ChildNodes[i].Name == "news")
                    {
                        // <news> tag found
                        newsNode = nodeRss.ChildNodes[i];
                        News news = new News();
                        news.Id = newsNode.ChildNodes[0].InnerText;
                        news.Name = newsNode.ChildNodes[1].InnerText;
                        news.Cat = newsNode.ChildNodes[2].InnerText;
                        news.Date = newsNode.ChildNodes[3].InnerText;
                        news.Detail = newsNode.ChildNodes[4].InnerText;
                        newsList.Add(news);
                    }
                }
                sortNewsList();
                rssReader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void sortNewsList()
        {
            News temp;
            for (int i = 0; i < newsList.Count; i++)
            {
                for (int j = i; j < newsList.Count; j++)
                {
                    if (newsList[i].id_sort < newsList[j].id_sort)
                    {
                        temp = newsList[i];
                        newsList[i] = newsList[j];
                        newsList[j] = temp;
                    }
                }
            }
        }
        public void reset()
        {
            rssReader = null;
            rssDoc = null;
            nodeRss = null;
            newsNode = null;
            newsList.Clear();
            newsList = null;
        }
    }
}
