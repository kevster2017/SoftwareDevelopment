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
}
