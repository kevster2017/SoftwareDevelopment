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
    public partial class MatchingNumbersCode : Form
    {
        public MatchingNumbersCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            int[] array = { 1, 2, 2, 3, 4, 5, 5, 6, 6, 7, 8, 9, 9, };\r\n            int count = 0;\r\n\r\n            for (int i = 0; i < array.Length; i++)\r\n            {\r\n                for (int j = i + 1; j < array.Length; j++)\r\n                {\r\n                    if (array[j] == array[i])\r\n                    {\r\n                        count++;\r\n                    }\r\n                }\r\n            }\r\n\r\n            outputLabel.Text = $\"This array contains {count} matches\";\r\n        }";

            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MatchingNumbers match = new MatchingNumbers();
            match.Show();
            this.Close();
        }
    }
}
