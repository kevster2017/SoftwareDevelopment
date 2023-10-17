using System;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Occurrences occur = new Occurrences();
            occur.Show();
            this.Close();
        }

        private void btnVowelCons_Click(object sender, EventArgs e)
        {
            VowelsAndCons vac = new VowelsAndCons();
            vac.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSumArray_Click(object sender, EventArgs e)
        {
            SumArray sum = new SumArray();
            sum.Show();
            this.Close();
        }

        private void btnPrimeNumber_Click(object sender, EventArgs e)
        {
            PrimeNumber prime = new PrimeNumber();
            prime.Show();
            this.Close();
        }
    }
}
