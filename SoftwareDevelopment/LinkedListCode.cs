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
    public partial class LinkedListCode : Form
    {
        public LinkedListCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            LinkedList<string> list = new LinkedList<string>();\r\n\r\n            list.AddLast(textString1.Text);\r\n            list.AddLast(textString2.Text);\r\n            list.AddLast(textString3.Text);\r\n\r\n            string original = \"\";\r\n\r\n            foreach (string item in list)\r\n            {\r\n                original += item + \" \";\r\n            }\r\n\r\n            outputLabel.Text = original;\r\n\r\n            var listRev = new LinkedList<string>(list.Reverse());\r\n\r\n            string reversed = \"\";\r\n\r\n            foreach (string item in listRev)\r\n            {\r\n                reversed += item + \" \";   \r\n            }\r\n\r\n            RevOutputLabel.Text = reversed;\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LinkedList linked = new LinkedList();
            linked.Show();
            this.Close();
        }
    }
}
