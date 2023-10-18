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
    public partial class MatchingNumbersCode : Form
    {
        public MatchingNumbersCode()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MatchingNumbers match = new MatchingNumbers();
            match.Show();
            this.Close();
        }
    }
}
