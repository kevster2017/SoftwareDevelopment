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

            int userInput = Convert.ToInt32(txtString.Text);


            static Boolean isPrime(int n)
            {
                if(n == 0 || n == 1)
                {
                    return false;
                }
                
                if(n == 2)
                {
                    return true;
                }

                for(int i = 2; i <= n/2; i++) 
                {
                    if(n%i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtString.Clear();
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
    }
}
