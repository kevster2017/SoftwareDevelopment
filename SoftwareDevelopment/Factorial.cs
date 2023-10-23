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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            static long Factorial(long n)
            {
                if (n == 0)
                {
                    return 1;
                }
                else
                {
                    return (n * Factorial(n - 1));
                }
            }


            string text = textBoxNum.Text;
            int num;


            if (String.IsNullOrEmpty(text))
            {
                outputLabel.Text = "Please enter a value";
            }
            else
            {

                if (int.TryParse(text, out num))
                {
                    long factNum = Convert.ToInt32(textBoxNum.Text);

                    long res = Factorial(num);

                    outputLabel.Text = $"The Factorial of {factNum} is {res}";

                }
                else
                {
                    outputLabel.Text = "Please enter a valid number";
                }

            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxNum.Clear();
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            FactorialCode fact = new FactorialCode();
            fact.Show();
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
