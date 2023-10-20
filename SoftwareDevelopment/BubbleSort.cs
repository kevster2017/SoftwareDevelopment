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
    public partial class BubbleSort : Form
    {
        public BubbleSort()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int[] arr = { 50, 99, 7, 83, 67, 1, 5, 15, 88 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j=0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                  
                }
            }

            string sorted = "";
            for (int i=0; i < arr.Length; i++)
            {
                sorted += arr[i] + ", ";
            }

            outputLabel.Text = sorted;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            BubbleSortCode bubble = new BubbleSortCode();
            bubble.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Sorting sort = new Sorting();
            sort.Show();
            this.Close();
        }
    }
}
