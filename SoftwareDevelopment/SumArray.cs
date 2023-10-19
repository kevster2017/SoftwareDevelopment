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
    public partial class SumArray : Form
    {
        public SumArray()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            SumArrayCode sum = new SumArrayCode();
            sum.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            outputLabel.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 4, 5, 6, 8, 4, 6, 98 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            outputLabel.Text = ($"The sum is: {sum}");
        }
    }
}
