using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Web_Browser__HW_RGM_2012_
{
    public partial class addfav : Form
    {
        string url;
        string name;
        public addfav(string u, string nm)
        {
            InitializeComponent();
            url = u;
            name = nm;
        }

        private void addFavorite(String url, string name)
        {
           XmlDocument myXml = new XmlDocument();
           XmlElement el = myXml.CreateElement(name);
           el.InnerText = url;
         
            if (!File.Exists("favorites.xml"))
            {
                XmlElement root = myXml.CreateElement("favorites");
                myXml.AppendChild(root);
                root.AppendChild(el);
            }
            else
            {
                myXml.Load("favorites.xml");
                myXml.DocumentElement.AppendChild(el);
            }
            myXml.Save("favorites.xml");   
        }

        private void saveb_Click(object sender, EventArgs e)
        {
            //Select addressbar from main windows
            addFavorite(urltb.Text.ToString(),nametb.Text.ToString());
            Close();
        }

        private void closeb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addfav_Load(object sender, EventArgs e)
        {
            urltb.Text = url;
        }
    }
}
