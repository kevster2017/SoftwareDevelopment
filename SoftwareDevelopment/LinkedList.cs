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
    public partial class LinkedList : Form
    {
        public LinkedList()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LinkedList<string> list = new LinkedList<string>();


            if (String.IsNullOrEmpty(textString1.Text) || String.IsNullOrEmpty(textString2.Text) || String.IsNullOrEmpty(textString3.Text))
            {
                outputLabel.Text = "Please enter a value for each input field";
            }
            else
            {


                    list.AddLast(textString1.Text);
                    list.AddLast(textString2.Text);
                    list.AddLast(textString3.Text);

                    string original = "";

                    foreach (string item in list)
                    {
                        original += item + " ";
                    }

                    outputLabel.Text = original;

                    var listRev = new LinkedList<string>(list.Reverse());

                    string reversed = "";

                    foreach (string item in listRev)
                    {
                        reversed += item + " ";
                    }

                    RevOutputLabel.Text = reversed;


            }
          
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            textString1.Text = "";
            textString2.Text = "";
            textString3.Text = "";
            outputLabel.Text = "";
            RevOutputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            LinkedListCode linked = new LinkedListCode();
            linked.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Sorting sort = new Sorting();
            sort.Show();
            this.Close();
        }
    }
}
