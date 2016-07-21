using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace Web_Browser__HW_RGM_2012_
{
    public partial class settings : Form
    {
        string home;
        public settings(string hp)
        {
            InitializeComponent();
            home = hp;
            homeptb.Text = home;
        }

        private void sethb_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("home.conf");
            tw.WriteLine(homeptb.Text);
            tw.Close();
        }

        private void clrhistoryb_Click(object sender, EventArgs e)
        {
            XmlDocument myXml = new XmlDocument();

            if (!File.Exists("history.xml"))
            {
                XmlElement root = myXml.CreateElement("history");
                myXml.AppendChild(root);
            }
            else
            {
                myXml.Load("history.xml");
                // myXml.SelectSingleNode("history");
                myXml.RemoveAll();
                XmlElement root = myXml.CreateElement("history");
                myXml.AppendChild(root);
            }
            myXml.Save("history.xml");

        }

        private void Closeb_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
