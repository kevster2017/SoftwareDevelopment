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
    public partial class FactorialCode : Form
    {
        public FactorialCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            static long Factorial(long n)\r\n            {\r\n                if (n == 0)\r\n                {\r\n                    return 1;\r\n                } else\r\n                {\r\n                    return (n * Factorial(n-1));    \r\n                }\r\n            }\r\n\r\n            long num = Convert.ToInt32(txtString.Text);\r\n\r\n            long res = Factorial(num);\r\n\r\n            outputLabel.Text = $\"The Factorial of {num} is {res}\";\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Factorial fact = new Factorial();
            fact.Show();
            this.Close();
        }
    }
}
