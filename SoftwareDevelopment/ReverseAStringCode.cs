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
    public partial class ReverseAStringCode : Form
    {
        public ReverseAStringCode()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtRevStringOutput rev = new txtRevStringOutput();
            rev.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = " private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            string userInput = txtString.Text;\r\n\r\n            static string Reverse(string userInput)\r\n            {\r\n                string rev = \"\";\r\n                int length = userInput.Length;\r\n\r\n                for (int i = length - 1; i >= 0; i--)\r\n                {\r\n                    rev += userInput[i];\r\n                }\r\n\r\n                return rev;\r\n            }\r\n           \r\n\r\n\r\n            outputLabel.Text = Reverse(userInput);\r\n\r\n\r\n        }";

            textBoxCode.Text = str;
        }
    }
}
