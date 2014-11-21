using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
namespace weatherhelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("今天");
            comboBox1.Items.Add("明天");
            comboBox1.Items.Add("后天");
            comboBox1.Text = "今天";
            
        }
           
        string getURL(string str)//转换城市名
        {
            string strl = System.Web.HttpUtility.UrlEncode(str, System.Text.Encoding.GetEncoding("gb2312"));
            return "http://php.weather.sina.com.cn/xml.php?city=" + strl + "&&password=DJOYnieT8234jlsK&&day=0";
        }
        string getURLtomorrow(string str) {
            string strl = System.Web.HttpUtility.UrlEncode(str, System.Text.Encoding.GetEncoding("gb2312"));
            return "http://php.weather.sina.com.cn/xml.php?city=" + strl + "&&password=DJOYnieT8234jlsK&&day=1";
        }
        string getURLafter(string str)
        {
            string strl = System.Web.HttpUtility.UrlEncode(str, System.Text.Encoding.GetEncoding("gb2312"));
            return "http://php.weather.sina.com.cn/xml.php?city=" + strl + "&&password=DJOYnieT8234jlsK&&day=2";
        }
        private string getWebClient(string url)//获取接口
        {
            string strHTML = "";
            WebClient myWebClient = new WebClient();
            Stream myStream = myWebClient.OpenRead(url);
            StreamReader sr = new StreamReader(myStream, System.Text.Encoding.GetEncoding("utf-8"));
            strHTML = sr.ReadToEnd();
            myStream.Close();
            return strHTML;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://php.weather.sina.com.cn/xml.php?city=%B1%B1%BE%A9&password=DJOYnieT8234jlsK&day=0";
                int flag = comboBox1.SelectedIndex;
                if (flag == 0) url = getURL(textBox1.Text);
                else if (flag == 1) url = getURLtomorrow(textBox1.Text);
                else if (flag == 2) url = getURLafter(textBox1.Text);


                //test code
                // textBoxtest.Text=(getURL(textBox1.Text));
                // richTextBoxtest.Text = getWebClient("http://php.weather.sina.com.cn/xml.php?city=%B1%B1%BE%A9&password=DJOYnieT8234jlsK&day=0");
                //realcode

                string rowText = getWebClient(url);
                //使用xmldocument解析
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(rowText);
                //doc.LoadXml(richTextBoxtest.Text);

                XmlNode root = doc.SelectSingleNode("Profiles/Weather");//查找根节点
                XmlNodeList nodeList = root.ChildNodes;//获取所有Profiles的子节点
                foreach (XmlNode xmlNode in nodeList)
                {
                    if ("city".Equals(xmlNode.Name))
                    {
                        labelcity.Text = "城市：" + xmlNode.InnerText;
                    }
                    if ("status1".Equals(xmlNode.Name))
                    {
                        labelstatus.Text = "白天;" + xmlNode.InnerText;
                    }
                    if ("status2".Equals(xmlNode.Name))
                    {
                        labelstatus.Text += "  夜间:" + xmlNode.InnerText;
                    }
                    if ("temperature1".Equals(xmlNode.Name))
                    {
                        labeltemp.Text = "摄氏 11";
                    }
                    if ("temperature2".Equals(xmlNode.Name))
                    {
                        labeltemp.Text += " ～ " + xmlNode.InnerText + " 度";
                    }
                    if ("direction1".Equals(xmlNode.Name))
                    {
                        labelwind.Text = xmlNode.InnerText;
                    }
                    if ("power1".Equals(xmlNode.Name))
                    {
                        labelwind.Text += " 风速" + xmlNode.InnerText + "级";
                    }
                    if ("pollution_l".Equals(xmlNode.Name))
                    {
                        labelpollution.Text = xmlNode.InnerText + "污染";
                    }
                    if ("pollution_s".Equals(xmlNode.Name))
                    {
                        labelpollution.Text += "," + xmlNode.InnerText;
                    }
                    if ("savedate_weather".Equals(xmlNode.Name))
                    {
                        labeldate.Text = "日期：" + xmlNode.InnerText;
                    }
                }
                string updatetimeQuery = @"published at(?<updatetime>.+)--";//正则查询
                Match findupdatetime = (new Regex(updatetimeQuery)).Match(rowText);
                if (findupdatetime.Success)
                    labelupdatetime.Text = "最后更新时间：" + findupdatetime.Groups["updatetime"].Value;
            }
            catch {
                MessageBox.Show("出错啦，请检查输入");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
