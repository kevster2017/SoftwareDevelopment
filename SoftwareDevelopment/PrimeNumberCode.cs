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
    public partial class PrimeNumberCode : Form
    {
        public PrimeNumberCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n\r\n            int userInput = Convert.ToInt32(txtString.Text);\r\n\r\n\r\n            static Boolean isPrime(int n)\r\n            {\r\n                if(n == 0 || n == 1)\r\n                {\r\n                    return false;\r\n                }\r\n                \r\n                if(n == 2)\r\n                {\r\n                    return true;\r\n                }\r\n\r\n                for(int i = 2; i <= n/2; i++) \r\n                {\r\n                    if(n%i == 0)\r\n                    {\r\n                        return false;\r\n                    }\r\n                }\r\n                return true;\r\n            }\r\n\r\n            Boolean res = isPrime(userInput);\r\n\r\n\r\n            if (res == false)\r\n            {\r\n                outputLabel.Text = ($\"{userInput} IS NOT a prime number\");\r\n            }\r\n          \r\n            else\r\n            {\r\n                outputLabel.Text = ($\"{userInput} IS a prime number\");\r\n            }\r\n\r\n\r\n     \r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrimeNumber prime = new PrimeNumber();
            prime.Show();
            this.Close();
        }
    }
}
