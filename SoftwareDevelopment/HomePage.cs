﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDevelopment
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRevStringOutput rev = new txtRevStringOutput();
            rev.Show();
            this.Close();
        }

        private void btnPal_Click(object sender, EventArgs e)
        {
            Palindrome pal = new Palindrome();
            pal.Show();
            this.Close();
        }
    }
}
