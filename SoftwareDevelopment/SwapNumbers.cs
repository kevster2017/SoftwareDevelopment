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
    public partial class SwapNumbers : Form
    {
        public SwapNumbers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);

            num2 = num1 + num2;
            num1 = num2 - num1;
            num2 = num2 - num1;

            outputLabel.Text = $"First number is now {num2} and second number is now {num1}";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            textBoxNum1.Clear();
            textBoxNum2.Clear();
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            SwapNumbersCode swap = new SwapNumbersCode();
            swap.Show();
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
