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
    public partial class SecondLargestCode : Form
    {
        public SecondLargestCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            int[] numArray = { 1, 2, 4, 5, 6, 8, 4, 6, 98 };\r\n          \r\n          \r\n            Array.Sort(numArray);\r\n\r\n            if (numArray.Length >= 2)\r\n            {\r\n                int secondHighest = numArray[numArray.Length - 2];\r\n                outputLabel.Text = $\"Second highest number is: {secondHighest}\";\r\n            }\r\n            else\r\n            {\r\n                outputLabel.Text = \"This array does not have two numbers\";\r\n            }\r\n         \r\n                     \r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SecondLargest second = new SecondLargest();
            second.Show();
            this.Close();
        }
    }
}
