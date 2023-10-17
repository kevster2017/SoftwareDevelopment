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
    public partial class VowelsAndConsCode : Form
    {
        public VowelsAndConsCode()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VowelsAndCons vac = new VowelsAndCons();
            vac.Show();
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            static Tuple<int, int> Count(string s)\r\n            {\r\n                int vowels = 0;\r\n                int cons = 0;\r\n\r\n                for(int i=0; i<s.Length; i++)\r\n                {\r\n                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')\r\n                    {\r\n                        vowels++;\r\n                    }\r\n\r\n                    else if (s[i] == ' ')\r\n                    {\r\n                        continue;\r\n                    }\r\n                    else\r\n                    {\r\n                        cons++;\r\n                    }\r\n                }\r\n               \r\n                return new Tuple<int, int> (vowels, cons);\r\n            }\r\n\r\n            string st = txtString.Text;\r\n            Tuple<int, int> counts = Count(st);\r\n            int vowels = counts.Item1;\r\n            int cons = counts.Item2;\r\n            outputLabel.Text = ($\"The string {st} contains {vowels} vowels and {cons} consonants\");\r\n        }";

            textBoxCode.Text = str;
        }
    }
}
