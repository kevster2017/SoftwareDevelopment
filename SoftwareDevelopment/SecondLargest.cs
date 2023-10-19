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
    public partial class SecondLargest : Form
    {
        public SecondLargest()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int[] numArray = { 1, 2, 4, 5, 6, 8, 4, 6, 98 };
          
          
            Array.Sort(numArray);

            if (numArray.Length >= 2)
            {
                int secondHighest = numArray[numArray.Length - 2];
                outputLabel.Text = $"Second highest number is: {secondHighest}";
            }
            else
            {
                outputLabel.Text = "This array does not have two numbers";
            }
         
                     
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            SecondLargestCode second = new SecondLargestCode();
            second.Show();
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
