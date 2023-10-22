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
    public partial class BinarySearchCode : Form
    {
        public BinarySearchCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            static int Search(int[] arr, int target)\r\n            {\r\n                int low = 0;\r\n                int high = arr.Length - 1;\r\n\r\n                while (low <= high)\r\n                {\r\n                    int mid = low + (high - low) / 2;\r\n\r\n                    if (arr[mid] == target)\r\n                    {\r\n                        return mid;\r\n                    }\r\n                    else if (arr[mid] < target)\r\n                    {\r\n                        low = mid + 1;\r\n                    }\r\n                    else\r\n                    {\r\n                        high = mid - 1;\r\n                    }\r\n\r\n                }\r\n\r\n                return -1;\r\n            }\r\n            int[] arr = { 50, 99, 7, 83, 67, 1, 5, 15, 88 };\r\n\r\n            Array.Sort(arr);\r\n\r\n            string sorted = string.Join(\", \", arr);\r\n\r\n            outputLabelSorted.Text = sorted;\r\n\r\n            int target = Convert.ToInt32(textBoxNum.Text);\r\n\r\n            int result = Search(arr, target);\r\n\r\n            if (result != -1)\r\n            {\r\n                outputLabel.Text = $\"Element {target} found at index {result}\";\r\n            }\r\n            else\r\n            {\r\n                outputLabel.Text = $\"Element {target} not found in array\";\r\n            }\r\n\r\n\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BinarySearch binary = new BinarySearch();
            binary.Show();
            this.Close();
        }

    }
}
