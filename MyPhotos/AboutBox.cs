using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPhotos
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string AboutText
        {
            get 
            { 
                return lblAboutText.Text; 
            }
            set { 
                lblAboutText.Text = value; 
            }
        }


    }
}
