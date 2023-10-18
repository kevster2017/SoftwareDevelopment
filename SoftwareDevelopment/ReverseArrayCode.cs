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
    public partial class ReverseArrayCode : Form
    {
        public ReverseArrayCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };\r\n            int[] array2 = array.Reverse().ToArray();\r\n\r\n            outputLabel.Text = string.Join(\", \", array2);\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReverseArray revArr = new ReverseArray();
            revArr.Show();
            this.Close();
        }
    }
}
