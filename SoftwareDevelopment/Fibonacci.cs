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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            static int Fibonacci(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
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
                    int fibNum = Convert.ToInt32(textBoxNum.Text);
                    string str = "";

                    for (int i = 0; i < num; i++)
                    {
                        str += (Fibonacci(i) + " ");
                    }

                    outputLabel.Text = $"Fibinacci series of {fibNum}: {str}";

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
            FibonacciCode fib = new FibonacciCode();
            fib.Show();
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
