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
    public partial class ReverseArray : Form
    {
        public ReverseArray()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = array.Reverse().ToArray();

            outputLabel.Text = string.Join(", ", array2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            ReverseArrayCode revArr = new ReverseArrayCode();
            revArr.Show();
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
