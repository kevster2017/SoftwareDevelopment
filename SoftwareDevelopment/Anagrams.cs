using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SoftwareDevelopment
{
    public partial class Anagrams : Form
    {
        public Anagrams()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string str1 = textString1.Text;
            string str2 = textString2.Text;
            bool isAnagram = false;

            if(String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
            {
                outputLabel.Text = "Please enter a value in both fields";
            } else
            {
                if (str1.Length != str2.Length)
                {
                    outputLabel.Text = $"{str1} and {str2} are not anagrams - Different number of characters";
                }
                else
                {
                    char[] anagram1 = str1.ToCharArray();
                    char[] anagram2 = str2.ToCharArray();

                    Array.Sort(anagram1);
                    Array.Sort(anagram2);

                    isAnagram = Enumerable.SequenceEqual(anagram1, anagram2);

                    if (isAnagram)
                    {
                        outputLabel.Text = $"{str1} and {str2} are anagrams";
                    }
                    else
                    {
                        outputLabel.Text = $"{str1} and {str2} are not anagrams";
                    }
                }
            }

        

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textString1.Text = "";
            textString2.Text = "";
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            AnagramsCode anagram = new AnagramsCode();
            anagram.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
