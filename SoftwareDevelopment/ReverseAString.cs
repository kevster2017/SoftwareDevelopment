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
    public partial class txtRevStringOutput : Form
    {
        public txtRevStringOutput()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtString.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();

        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            ReverseAStringCode code = new ReverseAStringCode();
            code.Show();
            this.Close();
        }


        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            static string Reverse(string userInput)
            {
                string rev = "";
                int length = userInput.Length;

                for (int i = length - 1; i >= 0; i--)
                {
                    rev += userInput[i];
                }
                return rev;
            }

            string userInput = txtString.Text;

            if (String.IsNullOrEmpty(userInput))
            {
                outputLabel.Text = "Please enter a value";
            }
            else
            {
                outputLabel.Text = Reverse(userInput);
            }

        }

        private void ReverseAString_Load(object sender, EventArgs e)
        {

        }
    }
}
