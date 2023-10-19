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
    public partial class FibonacciCode : Form
    {
        public FibonacciCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            static int Fibonacci(int n)\r\n            {\r\n                if (n <=1)\r\n                {\r\n                    return n;\r\n                } else\r\n                {\r\n                    return Fibonacci(n-1) + Fibonacci(n -2);\r\n                }\r\n            }\r\n\r\n            int num = Convert.ToInt32(textNum.Text);\r\n            string str = \"\";\r\n\r\n            for (int i = 0; i < num; i++) {\r\n                str += (Fibonacci(i) + \" \");\r\n            }\r\n\r\n            outputLabel.Text = $\"Fibinacci series of {num}: {str}\";\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Fibonacci fib = new Fibonacci();
            fib.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
