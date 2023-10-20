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
    public partial class Sorting : Form
    {
        public Sorting()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort bubble = new BubbleSort();
            bubble.Show();
            this.Close();
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            InsertionSort insert = new InsertionSort();
            insert.Show();
            this.Close();
        }
    }
}
