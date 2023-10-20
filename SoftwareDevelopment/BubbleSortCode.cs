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
    public partial class BubbleSortCode : Form
    {
        public BubbleSortCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            int[] arr = { 50, 99, 7, 83, 67, 1, 5, 15, 88 };\r\n\r\n            for (int i = 0; i < arr.Length; i++)\r\n            {\r\n                for (int j=0; j < arr.Length-i-1; j++)\r\n                {\r\n                    if (arr[j] > arr[j+1])\r\n                    {\r\n                        int temp = arr[j];\r\n                        arr[j] = arr[j + 1];\r\n                        arr[j + 1] = temp;\r\n                    }\r\n                  \r\n                }\r\n            }\r\n\r\n            string sorted = \"\";\r\n            for (int i=0; i < arr.Length; i++)\r\n            {\r\n                sorted += arr[i] + \", \";\r\n            }\r\n\r\n            outputLabel.Text = sorted;\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BubbleSort bubble = new BubbleSort();
            bubble.Show();
            this.Close();
        }
    }
}
