using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Browser__HW_RGM_2012_
{
    public partial class editfav : Form
    {
        string str;
        public editfav(string u)
        {
            InitializeComponent();
            str = u;
            addresstb.Text = u;
        }

        private void okb_Click(object sender, EventArgs e)
        {
            str = addresstb.Text;
            Close();
        }
        public string returnedit() {
            return str;
        }

        private void closeb_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
