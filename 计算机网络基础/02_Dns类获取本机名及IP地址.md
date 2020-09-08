```c#
using System;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string IP, name, localip = "127.0.0.1";
            string localname = Dns.GetHostName();//获取本机名
            //获取所有IP地址
            IPAddress[] ips = Dns.GetHostAddresses(localname);
            foreach(IPAddress ip in ips)
            {
                if (!ip.IsIPv6SiteLocal)
                {
                    //如果不是IPV6地址，获取本机IP地址
                    localip = ip.ToString();
                }
            }
            //将本机名和IP地址输出
            label1.Text += "本机名：" + localname + " 本机IP地址：" + localip;
            for(int i = 60; i < 65; i++)
            {
                IP = "192.168.1." + i;//生成IP字符串
                try
                {
                    IPHostEntry host = Dns.GetHostEntry(IP);
                    name = host.HostName.ToString();
                    label1.Text += "\nIP地址" + IP + "的主机名称是：" + name;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
```
