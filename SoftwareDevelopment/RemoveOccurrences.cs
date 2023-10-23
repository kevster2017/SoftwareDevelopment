using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SoftwareDevelopment
{
    public partial class RemoveOccurrences : Form
    {
        public RemoveOccurrences()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string str1 = txtString.Text;
            string char1 = textBoxRemLtr.Text;
            string char2 = textBoxRepLtr.Text;

           
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(char1) || String.IsNullOrEmpty(char2))
            {
                outputLabel.Text = "Please enter a value in each input field";
            }
            else

            {
                char rem = textBoxRemLtr.Text[0];
                char rep = textBoxRepLtr.Text[0];

                string str2 = str1.Replace($"{rem}", $"{rep}");

                outputLabel.Text = str2;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtString.Clear();
            textBoxRemLtr.Clear();
            textBoxRepLtr.Clear();
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            RemoveOccurencesCode remOcc = new RemoveOccurencesCode();
            remOcc.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
