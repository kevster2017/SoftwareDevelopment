using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SoftwareDevelopment
{
    public partial class Palindrome : Form
    {
        public Palindrome()
        {
            InitializeComponent();
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            PalindromeCode pal = new PalindromeCode();
            pal.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtString.Clear();
            outputLabel.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userInput = txtString.Text;

            static string Palindrome(string userInput)
            {
                string rev = "";
                int length = userInput.Length;

                for (int i = length - 1; i >= 0; i--)
                {
                    rev += userInput[i];
                }

                return rev;
            }
            string pal = Palindrome(userInput);

            if (String.IsNullOrEmpty(pal))
            {
                outputLabel.Text = "Please enter some text";
            }

            else
            {
                if (pal == userInput)
                {
                    outputLabel.Text = ($"{userInput} IS a Palindrome");
                }
                else
                {
                    outputLabel.Text = $"{userInput} IS NOT a Palindrome";
                }
            }

          

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
