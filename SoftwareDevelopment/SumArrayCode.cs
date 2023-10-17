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
    public partial class SumArrayCode : Form
    {
        public SumArrayCode()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SumArray sum = new SumArray();
            sum.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            int[] array = {1, 2, 4, 5, 6, 8, 4, 6, 98 };\r\n            int sum = 0;\r\n\r\n            foreach (int i in array)\r\n            {\r\n                sum += array[i];\r\n            }\r\n\r\n            outputLabel.Text = ($\"The sum is: {sum}\");\r\n        }";

            textBoxCode.Text = str;
        }
    }
}
