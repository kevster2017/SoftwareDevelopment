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
    public partial class SwapNumbersCode : Form
    {
        public SwapNumbersCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            int num1 = Convert.ToInt32(textBoxNum1.Text);\r\n            int num2 = Convert.ToInt32(textBoxNum2.Text);\r\n\r\n            num2 = num1 + num2;\r\n            num1 = num2 - num1;\r\n            num2 = num2 - num1;\r\n\r\n            outputLabel.Text = $\"First number is now {num1} and second number is now {num2}\";\r\n\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwapNumbers swap = new SwapNumbers();
            swap.Show();
            this.Close();
        }
    }
}
