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
    public partial class Occurrences : Form
    {
        public Occurrences()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtString.Clear();
            textBoxChar.Clear();
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            OccurrencesCode occur = new OccurrencesCode();
            occur.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            static int Occur(string s, char c)
            {
                int length = s.Length;
                int count = 0;

                for (int i=0; i < length; i++)
                {
                    if (s[i] == c)
                    {
                        count++;
                    }
                }
                return count;
            }

            if (String.IsNullOrEmpty(txtString.Text) || String.IsNullOrEmpty(textBoxChar.Text))
            {
                outputLabel.Text = "Please enter a value in both input fields";
            }
            else
            {

                string st = txtString.Text;
                char c = textBoxChar.Text[0];

                int count = Occur(st, c);

                if (count == 1)
                {
                    outputLabel.Text = ($"The letter {c} appears in {st} {count} time");
                } 
                else
                {
                    outputLabel.Text = ($"The letter {c} appears in {st} {count} times");
                }
               


            }

        }
    }
}
