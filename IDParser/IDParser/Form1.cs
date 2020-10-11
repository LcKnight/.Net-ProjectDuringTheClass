/*
 * author:https://github.com/LcKnight
 * email:819818746@qq.com
 * repo:https://github.com/LcKnight/.Net-ProjectDuringTheClass
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using System.Threading;

namespace IDParser
{
    enum Engines
    {
        Baidu=1,Bing,Google,Sogou
    };
    
    public partial class Form1 : Form
    {
        //private const string BaiduUrl = "https://www.baidu.com/s?wd=";
        //private const string BingUrl = "https://cn.bing.com/search?q=";
        //private const string GoogleUrl = "https://cn.bing.com/search?q=";
        //private const string SogouUrl = "https://www.sogou.com/web?query=";
        private static string[] SearchEngines = { "http://www.baidu.com/s?wd=", "http://cn.bing.com/search?q="
                                                 ,"http://cn.bing.com/search?q=","http://www.sogou.com/web?query="};
        private const string regexPattern= @"[1-9]\d{5}(18|19|20|(3\d))\d{2}((0[1-9])|(1[0-2]))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]";
        private const string regexUrlPattern = @"(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]";
        private Regex reg = new Regex(regexPattern);
        private Regex regUrl = new Regex(regexUrlPattern);
        private static HttpClient httpClient;
        private static ConcurrentQueue<string> CQ;
        private string key;
        private Engines[] engines;
        private int sum=0;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromMilliseconds(1000);
            
            CQ = new ConcurrentQueue<string>();
            engines = new Engines[4];
        }
        private async Task GetID(string url)
        {
            try
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                var text = httpClient.GetAsync(url).Result;
                var strText = await text.Content.ReadAsStringAsync();
                MatchCollection matches = reg.Matches(strText);
                if (matches.Count > 0)
                {
                    int i = 0;
                    while (i < matches.Count)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = matches[i].Value;
                        lvi.SubItems.Add(url);
                        this.Invoke(new Action(() => { this.listView1.Items.Add(lvi); }));
                        //this.listView1.Items.Add(lvi);
                        i++;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MatchCollection matches = reg.Matches("");
                
            }
            finally
            {
                
            }
        }
        private async  Task GetUrl(string url)
        {
            try
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                var text = httpClient.GetAsync(url).Result;
                var strText = await text.Content.ReadAsStringAsync();
                MatchCollection matches = regUrl.Matches(strText);
                if (matches.Count > 0)
                {
                    sum += matches.Count;
                    int i = 0;
                    while (i < matches.Count)
                    {
                        CQ.Enqueue(matches[i].Value);
                        i++;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MatchCollection matches = reg.Matches("");
                
            }
        }
        //private async Task SearchTask(string url)
        //{
        //    await Task.Run((string url)=> { });

        //}
        private async void Search()
        {
            string url;
            string text;
            for(int i=0;i<4;i++)
            {
                if(engines[i]==(Engines)i+1)
                {
                    CQ.Enqueue(SearchEngines[i]+key);
                }
            }
            while(CQ.TryDequeue(out url))
            {

                //text = httpClient.GetAsync(url).Result;
                await Task.Run(()=>GetID(url));

                await Task.Run(() => GetUrl(url));




                Console.WriteLine(sum);
                
                
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            this.key = KeytextBox.Text;
            if(BaiduradioButton.Checked)
            {
                engines[0] = Engines.Baidu;
            }
            if(BingradioButton.Checked)
            {
                engines[1] = Engines.Bing;
            }
            if(GoogleradioButton.Checked)
            {
                engines[2] = Engines.Google;
            }
            if(SogouradioButton.Checked)
            {
                engines[3] = Engines.Sogou;
            }
            Search();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
