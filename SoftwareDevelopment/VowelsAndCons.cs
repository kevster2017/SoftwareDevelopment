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
    public partial class VowelsAndCons : Form
    {
        public VowelsAndCons()
        {
            InitializeComponent();
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

        private void btnViewCode_Click_1(object sender, EventArgs e)
        {
            VowelsAndConsCode vac = new VowelsAndConsCode();
            vac.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            static Tuple<int, int> Count(string s)
            {
                int vowels = 0;
                int cons = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    {
                        vowels++;
                    }

                    else if (s[i] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        cons++;
                    }
                }

                return new Tuple<int, int>(vowels, cons);
            }

            string st = txtString.Text;
            Tuple<int, int> counts = Count(st);
            int vowels = counts.Item1;
            int cons = counts.Item2;
            int num;

            if (String.IsNullOrEmpty(st))
            {
                outputLabel.Text = "Please enter a value";
            }

            else if (int.TryParse(st, out num))
            {
                outputLabel.Text = "Please enter a valid string, numbers not allowed";
            }
            else

            {
                outputLabel.Text = ($"The string {st} contains \n{vowels} vowels and \n{cons} consonants");
            }
        }

    }
}
