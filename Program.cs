using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Web_Browser__HW_RGM_2012_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
    /*    public void changehome(string homeadd)
        {
            TextWriter tw = new StreamWriter("home.conf");
            tw.WriteLine(homeadd);
            tw.Close();
        }

        public string gethome() 
        {
            string hp;
            TextReader tr = new StreamReader("home.conf");
            hp = tr.ReadLine();
            tr.Close();
            
            return hp;
        }
     */
        static void Main()
        {
            TextReader tr = new StreamReader("home.conf");
            string homepage;
            homepage = tr.ReadLine();
            tr.Close();

            if (homepage==null)
                homepage = "http://www.google.com";
            
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WebXplorer(homepage));

             //   Application.Run(new favorites());
        }
    }
}
