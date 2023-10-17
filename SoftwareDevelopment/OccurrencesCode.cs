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
    public partial class OccurrencesCode : Form
    {
        public OccurrencesCode()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            static int Occur(string s, char c)\r\n            {\r\n                int length = s.Length;\r\n                int count = 0;\r\n\r\n                for (int i=0; i < length; i++)\r\n                {\r\n                    if (s[i] == c)\r\n                    {\r\n                        count++;\r\n                    }\r\n                }\r\n                return count;\r\n            }\r\n\r\n            string st = txtString.Text; ;\r\n            char c = textBoxChar.Text[0];\r\n\r\n            int count = Occur(st, c);\r\n\r\n            outputLabel.Text = ($\"The letter {c} appears in {st} {count} times\");\r\n        }";

            textBoxCode.Text = str;
        }
    }
}
