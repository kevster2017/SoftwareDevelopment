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
    public partial class BinarySearch : Form
    {
        public BinarySearch()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            static int Search(int[] arr, int target)
            {
                int low = 0;
                int high = arr.Length - 1;

                while (low <= high)
                {
                    int mid = low + (high - low) / 2;

                    if (arr[mid] == target)
                    {
                        return mid;
                    }
                    else if (arr[mid] < target)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }

                }

                return -1;
            }
            int[] arr = { 50, 99, 7, 83, 67, 1, 5, 15, 88 };

            Array.Sort(arr);

            string sorted = string.Join(", ", arr);

            outputLabelSorted.Text = sorted;

            int target = Convert.ToInt32(textBoxNum.Text);

            int result = Search(arr, target);

            if (result != -1)
            {
                outputLabel.Text = $"Element {target} found at index {result}";
            }
            else
            {
                outputLabel.Text = $"Element {target} not found in array";
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxNum.Text = "";
            outputLabelSorted.Text = "";
            outputLabel.Text = "";
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            BinarySearchCode binary = new BinarySearchCode();
            binary.Show();
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
