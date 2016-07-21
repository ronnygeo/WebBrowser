using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Threading;

namespace Web_Browser__HW_RGM_2012_
{
    public partial class favorites : Form
    {
        public favorites()
        {
            InitializeComponent();
            Addresstbox.Text = "http://";
        }


         private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
      {
         XmlNode xNode;
         TreeNode tNode;
         XmlNodeList nodeList;
         int i;
         
         // Loop through the XML nodes until the leaf is reached.
         // Add the nodes to the TreeView during the looping process.
         if (inXmlNode.HasChildNodes)
         {
            nodeList = inXmlNode.ChildNodes;
            for(i = 0; i<=nodeList.Count - 1; i++)
            {
               xNode = inXmlNode.ChildNodes[i];
               TreeNode tn = new TreeNode(xNode.Name);

 /*               if (nodeList.Count == 0)
                   tn.Tag = "child";
               else
                   tn.Tag = "parent";
  */              
                inTreeNode.Nodes.Add(tn);

                tNode = inTreeNode.Nodes[i]; 
               AddNode(xNode, tNode);
            }
         }
         else
         {
            // Here you need to pull the data from the XmlNode based on the
            // type of node, whether attribute values are required, and so forth.
            inTreeNode.Text = (inXmlNode.OuterXml).Trim();
         }
      }                  

        public void populatetree()
        {
            //Create a DOM Document and load the XML data into it.
            XmlDocument dom = new XmlDocument();
            dom.Load("favorites.xml");

            //Initialize the TreeView control.
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
            TreeNode tNode = new TreeNode();
            tNode = treeView1.Nodes[0];

            //Populate the TreeView with the DOM nodes.
            AddNode(dom.DocumentElement, tNode);

            treeView1.ExpandAll();
        }

        
       
        private void favorites_Load(object sender, EventArgs e)
        {
            XmlDocument myXml = new XmlDocument();
            XmlElement el = myXml.CreateElement("Favorites");
            populatetree();
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            addfav addfv = new addfav(Addresstbox.Text,"");
            addfv.ShowDialog();
            if (DialogResult==0)
            {
                XmlDocument myXml = new XmlDocument();
                XmlElement el = myXml.CreateElement("favorit");
                populatetree();
            }
        }

        private XmlTextWriter xr;

        public void exportToXml(TreeView tv, string filename)
        {
            xr = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
            xr.WriteStartDocument();
            //Write our root node
            xr.WriteStartElement(treeView1.Nodes[0].Text);
            foreach (TreeNode node in tv.Nodes)
            {
                saveNode(node.Nodes);
            }
            //Close the root node
            xr.WriteEndElement();
            xr.Close();
        }

        private void closeb_Click(object sender, EventArgs e)
        {
            Close();
            exportToXml(treeView1, "favorites.xml");
        }
        private void saveNode(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
                //If we have child nodes, we'll write 
                //a parent node, then iterrate through
                //the children
                if (node.Nodes.Count > 0)
                {
                    xr.WriteStartElement(node.Text);
                    saveNode(node.Nodes);
                    xr.WriteEndElement();
                }
                else //No child nodes, so we just write the text
                {
                    xr.WriteString(node.Text);
                }
            }
        }

        

        private void removeb_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Nodes.Count==0)
            {
                treeView1.SelectedNode.PrevVisibleNode.Remove();
            }
            else
            {               
                treeView1.SelectedNode.Remove();
            }
        }

        private void editb_Click(object sender, EventArgs e)
        {
            try
            {
                editfav efav = new editfav(treeView1.SelectedNode.Text);
                efav.ShowDialog();
                efav.Location = new Point(400, 300);
                efav.TopMost = true;

                if (DialogResult == 0)
                {
                    string edittxt;
                    edittxt = efav.returnedit();
                    treeView1.SelectedNode.Text = edittxt;
                }
            }
            catch (Exception) { }
        }


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string u = e.Node.Text;

            WebXplorer wxn = new WebXplorer(u);
            wxn.Show();
        }

       

    }
}
