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
    public partial class PrimeNumber : Form
    {
        public PrimeNumber()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            static Boolean isPrime(int n)
            {
                if (n == 0 || n == 1)
                {
                    return false;
                }

                if (n == 2)
                {
                    return true;
                }

                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
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

                    int userInput = Convert.ToInt32(textBoxNum.Text);


                    Boolean res = isPrime(userInput);


                    if (res == false)
                    {
                        outputLabel.Text = ($"{userInput} IS NOT a prime number");
                    }

                    else
                    {
                        outputLabel.Text = ($"{userInput} IS a prime number");
                    }

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
            PrimeNumberCode prime = new PrimeNumberCode();
            prime.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
