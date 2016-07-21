using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Web;
using System.Xml.Linq;
using System.Windows;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Xml;


namespace Web_Browser__HW_RGM_2012_
{
    public partial class WebXplorer : Form
    {
        
        int tabno = 1;

        public string printtxt="";
        string hp;
        
        //Temporary box to load webpage contents
     //   RichTextBox rtb = new RichTextBox();
        
        //String reader for printing
        // StringReader myReader;

        public WebXplorer(string adrs)
        {
            InitializeComponent();
            hp = adrs;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
      
            }

        public delegate RichTextBox addcontents(string a);

      
        private void WebXplorer_Load(object sender, EventArgs e)
        {
            addresstb.Text = hp;
           // var pglth=new Thread(() => 
                new_tab(addresstb.Text);
           // pglth.Start();
           
            //Load all favorites on page load
            Thread fth=new Thread(new ThreadStart(updatefavorites));
            fth.Start();
            
            //Load all history on page load
            Thread hth=new Thread(new ThreadStart(updatehistory));
            hth.Start();

   }

        public void new_tab(string urlvalue)
        {
            Label addresslbl = new Label();
            string addr = "http://";
            int t = tabno;
            tabno++;
            TabPage newtab = new TabPage("Tab");
            RichTextBox contentstext= new RichTextBox();
            contentstext.Width = tabs.Width-5;
            contentstext.Height = tabs.Height-20;
            contentstext.Multiline = true;
            contentstext.ReadOnly = true;
            contentstext.Text = "";

            //Checking if this is the first tab, then display homepage
            if (urlvalue == "http://")
            {
                addr = hp;
            }
            else
            {
                addr = urlvalue;
            }

            var bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += delegate
            {
                var bwth = new Thread(() => reportprog(bw));
                bwth.Start();
                httpfunction(addr,t);
                bwth.Join();
                bw.CancelAsync();
            };
        //   bw.ProgressChanged += delegate { };
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);

            var bw2 = new BackgroundWorker();
            bw2.WorkerReportsProgress = true;
            bw2.WorkerSupportsCancellation = true;
            bw2.DoWork += delegate
            {
                var bw2th = new Thread(() => reportprog(bw2));
                bw2th.Start();
                httpfunction(addr, t);
                bw2th.Join();
                bw2.CancelAsync();
            };
            bw2.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);

            if (bw.IsBusy)
                bw2.RunWorkerAsync();
            else
                bw.RunWorkerAsync();
            
            newtab.Controls.Add(contentstext);

            Label tnolb = new Label();
            tnolb.Text = t.ToString();

            this.Invoke(new MethodInvoker(delegate {addresslbl.Text = addr;}));
            this.Invoke(new MethodInvoker(delegate { addresstb.Text = addr; }));
            this.Invoke(new MethodInvoker(delegate {newtab.Controls.Add(addresslbl);}));
            this.Invoke(new MethodInvoker(delegate { newtab.Controls.Add(tnolb); }));

            this.Invoke(new MethodInvoker(delegate {tabs.TabPages.Add(newtab);}));
            this.Invoke(new MethodInvoker(delegate { tabs.SelectTab(tabs.TabCount - 1); }));
            
                }

        public void threadsleep()
        {
            Thread.Sleep(45);
        }

        public void httpfunction(string addr, int tbn)
        {
            RichTextBox contents = new RichTextBox();
            contents.Text = "";
            try
            {
                //Initializing the url
                Uri url = new Uri(addr);

                //HTTP Initialization
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(url);
                WebReq.Method = "GET";
                // WebReq.Timeout = 6500;
                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                //Gets information about the response
                Stream postdata = WebResp.GetResponseStream();
                int sc;
                sc = (int)WebResp.StatusCode;
                //Writes the status code & server to the toolstrip
                status.Text = sc.ToString();
                server.Text = WebResp.Server;

                //Now, we read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();
                StreamReader _Answer = new StreamReader(Answer);
                contents.Text = _Answer.ReadToEnd();

                for (int i = 0; i < tabs.TabCount; i++)
                {
                    if (tabs.TabPages[i].Controls[2].Text == tbn.ToString())
                    {
                        this.Invoke(new MethodInvoker(delegate { tabs.TabPages[i].Controls[0].Text = contents.Text; }));
                    }
                }


            }
            catch (Exception e)
            {
                for (int i = 0; i < tabs.TabCount; i++)
                {
                    if (tabs.TabPages[i].Controls[2].Text == tbn.ToString())
                    {
                        this.Invoke(new MethodInvoker(delegate { tabs.TabPages[i].Controls[0].Text = e.Message; }));
                    }
                }
            }
        }
       // private delegate void bw_progress(object sender, ProgressChangedEventArgs e);
        
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Progressbar.Value = e.ProgressPercentage;
        }

        public void reportprog(BackgroundWorker b) {

            for (int i = 0; i <= 100; i++)
            {
                b.ReportProgress(i);
                Thread.Sleep(10);
            }
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tabno = tabs.SelectedIndex;
                var lbladdr = (Label)tabs.TabPages[tabno].Controls[1];
                addresstb.Text = lbladdr.Text;
            }
            catch (Exception) { }
        }

         private void gob_Click(object sender, EventArgs e)
    {
            var nt = new Thread(() => new_tab(addresstb.Text));
           nt.Start();
        addhistory(addresstb.Text);

    }

         private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
         {
                 TabPage tb = tabs.SelectedTab;
                 tabs.TabPages.Remove(tb);

                 if (tabs.TabCount == 0)
                 {
                     if (MessageBox.Show(this, " There are no other open tabs. Close Meteora?", "Close Meteora", MessageBoxButtons.YesNo) == DialogResult.Yes)
                     {
                         this.Close();
                     }
                     else
                     {
                         new_tab(hp);
                         addresstb.Text = hp;
                         tabno--;
                     }
                 }
             }
         
         private void printToolStripMenuItem1_Click(object sender, EventArgs e)
         {
             try
             {
                 PrintDialog pdt = new PrintDialog();
                 printtxt = tabs.SelectedTab.Controls[0].Text;
                 pdt.Document = PrintDocument;
                 if (pdt.ShowDialog() == DialogResult.OK)
                 {
                     PrintDocument.Print();

                 }
             }
             catch (Exception) { }
         }

         private void printb_Click(object sender, EventArgs e)
         {
             try{
                 PrintDialog pd = new PrintDialog();

                 string pt= tabs.SelectedTab.Controls[0].Text;
                 pd.Document = PrintDocument;
                 
             if (pd.ShowDialog() == DialogResult.OK)
             {
                 
                 printtxt = pt;
                 PrintDocument.Print();
             }

             }
             catch (Exception) { }
         }


        
        // A structure containing information of current window.
         struct client
         {
             public Point location;
             public int width;
             public int height;
             public int tabw;
             public int tabh;
             public int tbw;
             public int tbh;
             public Point rendbp;
         };

         client restore;

         bool fullscreen = false;

         void Fullscreen()
         {
             try
             {
             if (fullscreen == false)
             {
                 this.restore.location = this.Location;
                 this.restore.width = this.Width;
                 this.restore.height = this.Height;
                 this.restore.tabw = this.tabs.Width;
                 this.restore.tabh = this.tabs.Height;
                 this.restore.rendbp = this.renderb.Location;
                 this.restore.tbw =this.tabs.TabPages[tabs.SelectedIndex].Controls[0].Width;
                 this.restore.tbh = this.tabs.TabPages[tabs.SelectedIndex].Controls[0].Height;
                 this.TopMost = true;
                 this.FormBorderStyle = FormBorderStyle.None;
                 this.Width = Screen.PrimaryScreen.Bounds.Width;
                 this.Height = Screen.PrimaryScreen.Bounds.Height;
                 this.Location = new Point(0,0);
                 this.tabs.Width = this.Width - 40;
                 this.tabs.Height = this.Height -130;
                 this.tabs.TabPages[tabs.SelectedIndex].Controls[0].Width = this.tabs.Width - 10;
                 this.tabs.TabPages[tabs.SelectedIndex].Controls[0].Height= this.tabs.Height - 30;
                 this.renderb.Location = new Point(this.Width - 125, this.Height - 23);
                
                 fullscreen = true;
             }
             else
             {
                 this.TopMost = false;
                 this.Location = this.restore.location;
                 this.Width = this.restore.width;
                 this.Height = this.restore.height-40;
                 this.tabs.Width = this.restore.tabw;
                 this.tabs.Height = this.restore.tabh;
                 this.renderb.Location = this.restore.rendbp;
                 this.tabs.TabPages[tabs.SelectedIndex].Controls[0].Width = this.restore.tbw ;
                 this.tabs.TabPages[tabs.SelectedIndex].Controls[0].Height = this.restore.tbh;
                 this.WindowState = FormWindowState.Normal;
                 this.FormBorderStyle = FormBorderStyle.Sizable;
                 fullscreen = false;
             }
             }catch(Exception){}
         }

         private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Fullscreen();
            
         }

         public void updatefavorites()
         {

             XmlDocument xfavload = new XmlDocument();
             xfavload.Load("favorites.xml");
             XmlNodeList nodelist = xfavload.SelectNodes("//favorites/*");
             foreach (XmlNode node in nodelist)
             {
                 ToolStripMenuItem newfav = new ToolStripMenuItem();
                 newfav.Text = node.Name;
                 this.Invoke(new MethodInvoker(delegate { favoritesmenu.DropDownItems.Add(newfav); }));
             }


         }

         public void updatehistory()
         {
             var clrhistory = historymenu.DropDownItems[0];
             this.Invoke(new MethodInvoker(delegate { historymenu.DropDownItems.Clear(); }));
             this.Invoke(new MethodInvoker(delegate { historymenu.DropDownItems.Add(clrhistory); }));
             XmlDocument xhistoryload = new XmlDocument();
             xhistoryload.Load("history.xml");
             XmlNodeList hnodelist = xhistoryload.SelectNodes("//history/link");
             foreach (XmlNode node in hnodelist)
             {
                 ToolStripMenuItem newfav = new ToolStripMenuItem();
                 newfav.Text = node.InnerText;
                 this.Invoke(new MethodInvoker(delegate { historymenu.DropDownItems.Add(newfav); }));
             }
         }

         public void addhistory(string url)
         {
             XmlDocument myXml = new XmlDocument();
             XmlElement el = myXml.CreateElement("link");
             el.InnerText = url;

             if (!File.Exists("history.xml"))
             {
                 XmlElement root = myXml.CreateElement("history");
                 root.AppendChild(el);
                 myXml.AppendChild(root);
             }
             else
             {
                 myXml.Load("history.xml");
                 myXml.DocumentElement.AppendChild(el);
             }

             myXml.Save("history.xml");
             updatehistory();
         }

         private void addfavb_Click(object sender, EventArgs e)
         {
             addfav adddiag = new addfav(addresstb.Text.ToString(), "");

             DialogResult favresult = adddiag.ShowDialog();
             if (DialogResult == 0)
                 clearupdatefavmenu();
         }

     
         private void renderb_Click(object sender, EventArgs e)
         {            
                 try
             {
                 //Get the current selected tab index
                 int tabno = tabs.SelectedIndex;

                 //create a WebBrowser object
                 WebBrowser browser = new WebBrowser();
                 browser.Navigate(addresstb.Text.ToString());
                 browser.Dock = DockStyle.Fill;
                 tabs.TabPages[tabno].Controls[0].Visible = false;
                 tabs.TabPages[tabno].Controls[1].Visible = false;
                 tabs.TabPages[tabno].Controls[2].Visible = false;
                 tabs.TabPages[tabno].Controls.Add(browser);


                 //We can use this code to render the page in a new tab

                 /*        TabPage newtab = new TabPage(("Tab " +tabno).ToString());
                         newtab.Controls.Add(browser);
                         tabs.TabPages.Add(newtab);
                         tabs.SelectTab(tabcount-1);
                         tabcount++;     
                  */
              
             }
             catch (Exception){}
             }
         
        private void hideAllButtonsToolStripMenuItem_Click(object sender, EventArgs e)
         {
             flowLayoutPanel1.Visible = false;

             tabs.Location = new Point(15, 40);
             tabs.Size = new Size(811, 570);
         }

         private void unhideButtonsToolStripMenuItem_Click(object sender, EventArgs e)
         {
             flowLayoutPanel1.Visible = true;

             tabs.Location = new Point(15, 100);
             tabs.Size = new Size(811, 514);
         }
        
        private void setAsHomeToolStripMenuItem_Click(object sender, EventArgs e)
         {
             TextWriter tw = new StreamWriter("home.conf");
             tw.WriteLine(addresstb.Text);
             tw.Close();
         }

         private void windowToolStripMenuItem_Click(object sender, EventArgs e)
         {
             WebXplorer wx = new WebXplorer(hp);
             wx.Show();
         }

         private void tabToolStripMenuItem_Click(object sender, EventArgs e)
         {
           //  TabPage newtab = new TabPage(("Tab " + tabcount).ToString());
             addresstb.Text = hp;
             var t = new Thread(() => new_tab(addresstb.Text));
             t.Start();
             
         }

         private void homeb_Click(object sender, EventArgs e)
         {
           try{
               string address = hp;
            
                 tabs.TabPages[tabs.SelectedIndex].Controls[0].Visible = true;
                 int tno = tabs.SelectedIndex + 1;
             //    if(tabs.TabPages[tabs.SelectedIndex].Controls[2].Enabled)
            //         tabs.TabPages[tabs.SelectedIndex].Controls[2].Visible = false;
                     var rth = new Thread(() => httpfunction(address,tno));
                     rth.Start();
                     backgroundWorker1.RunWorkerAsync();
                    }catch (Exception exc)
             {
                 tabs.TabPages[tabs.SelectedIndex].Controls[0].Text = exc.Message;
             }
             
         }

         private void favoritesManagerToolStripMenuItem_Click(object sender, EventArgs e)
         {
             favorites favwindow = new favorites();
             favwindow.TopLevel=true;
             favwindow.ShowDialog();
             if (DialogResult == 0)
             {
                 clearupdatefavmenu();
             }
         }

         private void copyToolStripMenuItem_Click(object sender, EventArgs e)
         {
             RichTextBox rtb=(RichTextBox)tabs.TabPages[tabs.SelectedIndex].Controls[0];
             rtb.Copy();

         }

         private void cutToolStripMenuItem_Click(object sender, EventArgs e)
         {
             RichTextBox rtb = (RichTextBox)tabs.TabPages[tabs.SelectedIndex].Controls[0];
             rtb.Cut();
         }

         private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
         {
             RichTextBox rtb = (RichTextBox)tabs.TabPages[tabs.SelectedIndex].Controls[0];
             rtb.Paste();
         }

         private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
         {
             RichTextBox rtb = (RichTextBox)tabs.TabPages[tabs.SelectedIndex].Controls[0];
             rtb.SelectAll();
         }

         public void clearupdatefavmenu() {
             var favman = favoritesmenu.DropDownItems[0];
             favoritesmenu.DropDownItems.Clear();
             favoritesmenu.DropDownItems.Add(favman);
             updatefavorites();
         }

         public void refreshtab() {
             try
             {
                 int tno;
                 tno = tabs.SelectedIndex + 1;
                 string address;
                 address = addresstb.Text;
            
                 tabs.TabPages[tabs.SelectedIndex].Controls[0].Visible = true;
               //  tabs.TabPages[tabs.SelectedIndex].Controls[2].Visible = false;
                     var rth = new Thread(() => httpfunction(address,tno));
                     rth.Start();
                   
                     backgroundWorker1.RunWorkerAsync();
                    }catch (Exception exc)
             {
                 tabs.TabPages[tabs.SelectedIndex].Controls[0].Text = exc.Message;
             }
         }
        
        private void refreshb_Click(object sender, EventArgs e)
         {
             refreshtab();
             }
         
        public void clearhistory() {

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

             //Reload all the history items on menu
             var clrhistory = historymenu.DropDownItems[0];
             historymenu.DropDownItems.Clear();
             historymenu.DropDownItems.Add(clrhistory);
             updatehistory(); 
         }

         private void historyToolStripMenuItem_Click(object sender, EventArgs e)
         {
             clearhistory();
         }

         private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
         {
             clearhistory();
         }

         private void historymenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
         {
             string address;
             address = e.ClickedItem.Text;
             if (e.ClickedItem != historymenu.DropDownItems[0])
             {
                 new_tab(address);
                 var ahth=new Thread(() =>addhistory(address));
                 ahth.Start();

             }
         }

         private void favoritesmenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
         {
             string ads="";

             XmlDocument xfavload = new XmlDocument();
             xfavload.Load("favorites.xml");
             XmlNodeList nodelist = xfavload.SelectNodes("//favorites/*");
             foreach (XmlNode node in nodelist)
             {
                 if (node.Name == e.ClickedItem.Text)
                 {
                     ads = node.InnerText;
                     addhistory(ads);
                     addresstb.Text = ads;
                 }
             }

             if (e.ClickedItem != favoritesmenu.DropDownItems[0])
             {
                 var fvcth=new Thread(() => new_tab(addresstb.Text));
                 fvcth.Start();
             }
             
         }

         private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
         {
             settings setprop = new settings(hp);
             setprop.TopMost = true;
             setprop.Show();
             

             //Reload all the history items on menu
                 var clrhistory = historymenu.DropDownItems[0];
                 historymenu.DropDownItems.Clear();
                 historymenu.DropDownItems.Add(clrhistory);
                 updatehistory();
         }

         private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
         {
             favorites fav= new favorites();
             fav.TopMost = true;
             fav.ShowDialog();
             if (DialogResult == 0)
                 clearupdatefavmenu();
         }

         private void exitToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show(this, "Do you really want to close Meteora? ", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 Close();
         }

         private void fullscreenb_Click(object sender, EventArgs e)
         {
             Fullscreen();
         }

         private void historymenu_Click(object sender, EventArgs e)
         {

         }

         private void viewmenu_MouseHover(object sender, EventArgs e)
         {
             if (fullscreen == true)
             {
                 hideAllButtonsToolStripMenuItem.Visible = false;
                 unhideButtonsToolStripMenuItem.Visible = false;
             }
             else
             {
                 hideAllButtonsToolStripMenuItem.Visible = true;
                 unhideButtonsToolStripMenuItem.Visible = true;
             }
         }

         private void addresstb_KeyUp(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter) {
                 gob_Click(sender, null);
             }
         }

         private void PrintDocument_PrintPage(object sender, PrintPageEventArgs ev)
         {
             int linesPerPage = 0;
             float leftMargin = ev.MarginBounds.Left;
             float topMargin = ev.MarginBounds.Top;
             Font printFont = new Font("Arial", 10);
             SolidBrush myBrush = new SolidBrush(Color.Black);

             int charactersOnPage = 0;

             // Sets the value of charactersOnPage to the number of characters 
             // of stringToPrint that will fit within the bounds of the page.
             ev.Graphics.MeasureString(printtxt, printFont, ev.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

             // Draws the string within the bounds of the page
             ev.Graphics.DrawString(printtxt, printFont, Brushes.Black, ev.MarginBounds, StringFormat.GenericTypographic);

             // Remove the portion of the string that has been printed.
             printtxt = printtxt.Substring(charactersOnPage);

             // Check to see if more pages are to be printed.
             ev.HasMorePages = (printtxt.Length > 0);
         }

         private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
         {
             printtxt = "";
         }

         private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
         {
             {
                 try
                 {
                     for (int i = 0; i <= 100; i++)
                     {
                         backgroundWorker1.ReportProgress(i);
                         threadsleep();
                     }
                     httpfunction(addresstb.Text, tabs.SelectedIndex + 1);
                     backgroundWorker1.CancelAsync();
                 }
                 catch (Exception) { }
             }

         }

         private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
         {
             Progressbar.Value = e.ProgressPercentage;
         }



        


         

   

       

         
    }    

}
