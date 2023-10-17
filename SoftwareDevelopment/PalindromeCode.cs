using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareDevelopment
{
    public partial class PalindromeCode : Form
    {
        public PalindromeCode()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            string userInput = txtString.Text;\r\n\r\n            static string Palindrome(string userInput)\r\n            {\r\n                string rev = \"\";\r\n                int length = userInput.Length;\r\n\r\n                for (int i = length - 1; i >= 0; i--)\r\n                {\r\n                    rev += userInput[i];\r\n                }\r\n\r\n                return rev;\r\n            }\r\n\r\n            string pal = Palindrome(userInput);\r\n\r\n           \r\n            if (pal == userInput)\r\n            {\r\n                outputLabel.Text = ($\"{userInput} IS a Palindrome\");\r\n            } else\r\n            {\r\n                outputLabel.Text = $\"{userInput} IS NOT a Palindrome\";\r\n            }\r\n           \r\n        }";

            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = vScrollBar1.Value;
            textBoxCode.SelectionStart = scrollValue; // Set the selection start to the desired scroll position
            textBoxCode.ScrollToCaret(); // Scroll to the caret position
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = Math.Max(0, textBoxCode.Text.Length - textBoxCode.Height);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
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
