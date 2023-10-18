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
    public partial class RemoveOccurencesCode : Form
    {
        public RemoveOccurencesCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            string str1 = txtString.Text;\r\n            char rem = textBoxRemLtr.Text[0];\r\n            char rep = textBoxRepLtr.Text[0];\r\n                      \r\n            string str2 = str1.Replace($\"{rem}\", $\"{rep}\");\r\n\r\n            outputLabel.Text = str2;\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RemoveOccurrences remOcc = new RemoveOccurrences();
            remOcc.Show();
            this.Close();
        }
    }
}
