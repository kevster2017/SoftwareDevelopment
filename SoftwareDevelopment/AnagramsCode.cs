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
    public partial class AnagramsCode : Form
    {
        public AnagramsCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string str = "private void btnSubmit_Click(object sender, EventArgs e)\r\n        {\r\n            string str1 = textString1.Text;\r\n            string str2 = textString2.Text;\r\n            bool isAnagram = false;\r\n\r\n            if (str1.Length != str2.Length)\r\n            {\r\n                outputLabel.Text = $\"{str1} and {str2} are not anagrams - Different number of characters\";\r\n            }\r\n            else\r\n            {\r\n                char[] anagram1 = str1.ToCharArray();\r\n                char[] anagram2 = str2.ToCharArray();\r\n\r\n                Array.Sort(anagram1);\r\n                Array.Sort(anagram2);\r\n\r\n                isAnagram = Enumerable.SequenceEqual(anagram1, anagram2);\r\n\r\n                if (isAnagram)\r\n                {\r\n                    outputLabel.Text = $\"{str1} and {str2} are anagrams\";\r\n                }\r\n                else\r\n                {\r\n                    outputLabel.Text = $\"{str1} and {str2} are not anagrams\";\r\n                }\r\n            }\r\n\r\n        }";
            textBoxCode.Text = str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Anagrams anagram = new Anagrams();
            anagram.Show();
            this.Close();
        }
    }
}
