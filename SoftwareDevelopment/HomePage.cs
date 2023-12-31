﻿using System;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRevStringOutput rev = new txtRevStringOutput();
            rev.Show();
            this.Close();
        }

        private void btnPal_Click(object sender, EventArgs e)
        {
            Palindrome pal = new Palindrome();
            pal.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Occurrences occur = new Occurrences();
            occur.Show();
            this.Close();
        }

        private void btnVowelCons_Click(object sender, EventArgs e)
        {
            VowelsAndCons vac = new VowelsAndCons();
            vac.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSumArray_Click(object sender, EventArgs e)
        {
            SumArray sum = new SumArray();
            sum.Show();
            this.Close();
        }

        private void btnPrimeNumber_Click(object sender, EventArgs e)
        {
            PrimeNumber prime = new PrimeNumber();
            prime.Show();
            this.Close();
        }

        private void btnMatchingNumbers_Click(object sender, EventArgs e)
        {
            MatchingNumbers match = new MatchingNumbers();
            match.Show();
            this.Close();
        }

        private void btnFactorialInteger_Click(object sender, EventArgs e)
        {
            Factorial fact = new Factorial();
            fact.Show();
            this.Close();
        }

        private void btnRemoveOccurrences_Click(object sender, EventArgs e)
        {
            RemoveOccurrences remOcc = new RemoveOccurrences();
            remOcc.Show();
            this.Close();
        }

        private void btnReverseArray_Click(object sender, EventArgs e)
        {
            ReverseArray revArr = new ReverseArray();
            revArr.Show();
            this.Close();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            SwapNumbers swap = new SwapNumbers();
            swap.Show();
            this.Close();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            Fibonacci fib = new Fibonacci();
            fib.Show();
            this.Close();
        }

        private void btnSecondLargest_Click(object sender, EventArgs e)
        {
            SecondLargest second = new SecondLargest();
            second.Show();
            this.Close();
        }

        private void btnAnagrams_Click(object sender, EventArgs e)
        {
            Anagrams anagram = new Anagrams();
            anagram.Show();
            this.Close();
        }

        private void btnSorting_Click_1(object sender, EventArgs e)
        {
            Sorting sort = new Sorting();
            sort.Show();
            this.Close();
        }
    }
}
