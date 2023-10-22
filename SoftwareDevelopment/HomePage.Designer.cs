namespace SoftwareDevelopment
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRevStr = new Button();
            label1 = new Label();
            btnPal = new Button();
            Occurences = new Button();
            btnVowelCons = new Button();
            btnFactorialInteger = new Button();
            btnMatchingNumbers = new Button();
            btnPrimeNumber = new Button();
            label2 = new Label();
            label3 = new Label();
            btnSumArray = new Button();
            btnRemoveOccurrences = new Button();
            btnReverseArray = new Button();
            btnSwap = new Button();
            btnFibonacci = new Button();
            btnSecondLargest = new Button();
            btnAnagrams = new Button();
            btnSorting = new Button();
            SuspendLayout();
            // 
            // btnRevStr
            // 
            btnRevStr.BackColor = Color.FromArgb(255, 128, 128);
            btnRevStr.Location = new Point(96, 177);
            btnRevStr.Margin = new Padding(4);
            btnRevStr.Name = "btnRevStr";
            btnRevStr.Size = new Size(188, 59);
            btnRevStr.TabIndex = 0;
            btnRevStr.Text = "Reverse a string";
            btnRevStr.UseVisualStyleBackColor = false;
            btnRevStr.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(378, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(329, 23);
            label1.TabIndex = 1;
            label1.Text = "Select an algorithm to test";
            // 
            // btnPal
            // 
            btnPal.BackColor = Color.FromArgb(255, 128, 128);
            btnPal.Location = new Point(329, 177);
            btnPal.Name = "btnPal";
            btnPal.Size = new Size(161, 59);
            btnPal.TabIndex = 2;
            btnPal.Text = "Palindrome";
            btnPal.UseVisualStyleBackColor = false;
            btnPal.Click += btnPal_Click;
            // 
            // Occurences
            // 
            Occurences.BackColor = Color.FromArgb(255, 128, 128);
            Occurences.Location = new Point(546, 177);
            Occurences.Name = "Occurences";
            Occurences.Size = new Size(161, 59);
            Occurences.TabIndex = 3;
            Occurences.Text = "Occurrences";
            Occurences.UseVisualStyleBackColor = false;
            Occurences.Click += button1_Click_1;
            // 
            // btnVowelCons
            // 
            btnVowelCons.BackColor = Color.FromArgb(255, 128, 128);
            btnVowelCons.Location = new Point(744, 177);
            btnVowelCons.Name = "btnVowelCons";
            btnVowelCons.Size = new Size(151, 59);
            btnVowelCons.TabIndex = 4;
            btnVowelCons.Text = "Vowels and Consonants";
            btnVowelCons.UseVisualStyleBackColor = false;
            btnVowelCons.Click += btnVowelCons_Click;
            // 
            // btnFactorialInteger
            // 
            btnFactorialInteger.BackColor = Color.Blue;
            btnFactorialInteger.ForeColor = SystemColors.ButtonHighlight;
            btnFactorialInteger.Location = new Point(744, 421);
            btnFactorialInteger.Name = "btnFactorialInteger";
            btnFactorialInteger.Size = new Size(151, 59);
            btnFactorialInteger.TabIndex = 8;
            btnFactorialInteger.Text = "Factorial of Integer";
            btnFactorialInteger.UseVisualStyleBackColor = false;
            btnFactorialInteger.Click += btnFactorialInteger_Click;
            // 
            // btnMatchingNumbers
            // 
            btnMatchingNumbers.BackColor = Color.Blue;
            btnMatchingNumbers.ForeColor = SystemColors.ButtonHighlight;
            btnMatchingNumbers.Location = new Point(546, 421);
            btnMatchingNumbers.Name = "btnMatchingNumbers";
            btnMatchingNumbers.Size = new Size(161, 59);
            btnMatchingNumbers.TabIndex = 7;
            btnMatchingNumbers.Text = "Matching numbers";
            btnMatchingNumbers.UseVisualStyleBackColor = false;
            btnMatchingNumbers.Click += btnMatchingNumbers_Click;
            // 
            // btnPrimeNumber
            // 
            btnPrimeNumber.BackColor = Color.Blue;
            btnPrimeNumber.ForeColor = SystemColors.ButtonHighlight;
            btnPrimeNumber.Location = new Point(329, 421);
            btnPrimeNumber.Name = "btnPrimeNumber";
            btnPrimeNumber.Size = new Size(161, 59);
            btnPrimeNumber.TabIndex = 6;
            btnPrimeNumber.Text = "Prime Number";
            btnPrimeNumber.UseVisualStyleBackColor = false;
            btnPrimeNumber.Click += btnPrimeNumber_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 126);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 9;
            label2.Text = "Strings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 373);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 10;
            label3.Text = "Numbers";
            // 
            // btnSumArray
            // 
            btnSumArray.BackColor = Color.Blue;
            btnSumArray.ForeColor = SystemColors.ButtonHighlight;
            btnSumArray.Location = new Point(96, 421);
            btnSumArray.Margin = new Padding(4);
            btnSumArray.Name = "btnSumArray";
            btnSumArray.Size = new Size(188, 59);
            btnSumArray.TabIndex = 12;
            btnSumArray.Text = "Sum up array elements";
            btnSumArray.UseVisualStyleBackColor = false;
            btnSumArray.Click += btnSumArray_Click;
            // 
            // btnRemoveOccurrences
            // 
            btnRemoveOccurrences.BackColor = Color.FromArgb(255, 128, 128);
            btnRemoveOccurrences.Location = new Point(96, 270);
            btnRemoveOccurrences.Name = "btnRemoveOccurrences";
            btnRemoveOccurrences.Size = new Size(188, 59);
            btnRemoveOccurrences.TabIndex = 13;
            btnRemoveOccurrences.Text = "Remove Occurrences";
            btnRemoveOccurrences.UseVisualStyleBackColor = false;
            btnRemoveOccurrences.Click += btnRemoveOccurrences_Click;
            // 
            // btnReverseArray
            // 
            btnReverseArray.BackColor = Color.FromArgb(255, 128, 128);
            btnReverseArray.Location = new Point(329, 270);
            btnReverseArray.Margin = new Padding(4);
            btnReverseArray.Name = "btnReverseArray";
            btnReverseArray.Size = new Size(161, 59);
            btnReverseArray.TabIndex = 14;
            btnReverseArray.Text = "Reverse an array";
            btnReverseArray.UseVisualStyleBackColor = false;
            btnReverseArray.Click += btnReverseArray_Click;
            // 
            // btnSwap
            // 
            btnSwap.BackColor = Color.Blue;
            btnSwap.ForeColor = SystemColors.ButtonHighlight;
            btnSwap.Location = new Point(96, 513);
            btnSwap.Margin = new Padding(4);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new Size(188, 59);
            btnSwap.TabIndex = 16;
            btnSwap.Text = "Swap two numbers";
            btnSwap.UseVisualStyleBackColor = false;
            btnSwap.Click += btnSwap_Click;
            // 
            // btnFibonacci
            // 
            btnFibonacci.BackColor = Color.Blue;
            btnFibonacci.ForeColor = SystemColors.ButtonHighlight;
            btnFibonacci.Location = new Point(329, 513);
            btnFibonacci.Name = "btnFibonacci";
            btnFibonacci.Size = new Size(161, 59);
            btnFibonacci.TabIndex = 15;
            btnFibonacci.Text = "Fibonacci";
            btnFibonacci.UseVisualStyleBackColor = false;
            btnFibonacci.Click += btnFibonacci_Click;
            // 
            // btnSecondLargest
            // 
            btnSecondLargest.BackColor = Color.Blue;
            btnSecondLargest.ForeColor = SystemColors.ButtonHighlight;
            btnSecondLargest.Location = new Point(546, 513);
            btnSecondLargest.Margin = new Padding(4);
            btnSecondLargest.Name = "btnSecondLargest";
            btnSecondLargest.Size = new Size(161, 59);
            btnSecondLargest.TabIndex = 17;
            btnSecondLargest.Text = "Second largest array number";
            btnSecondLargest.UseVisualStyleBackColor = false;
            btnSecondLargest.Click += btnSecondLargest_Click;
            // 
            // btnAnagrams
            // 
            btnAnagrams.BackColor = Color.FromArgb(255, 128, 128);
            btnAnagrams.Location = new Point(546, 270);
            btnAnagrams.Margin = new Padding(4);
            btnAnagrams.Name = "btnAnagrams";
            btnAnagrams.Size = new Size(161, 59);
            btnAnagrams.TabIndex = 18;
            btnAnagrams.Text = "Anagrams";
            btnAnagrams.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAnagrams.UseVisualStyleBackColor = false;
            btnAnagrams.Click += btnAnagrams_Click;
            // 
            // btnSorting
            // 
            btnSorting.BackColor = Color.FromArgb(192, 255, 255);
            btnSorting.Location = new Point(890, 542);
            btnSorting.Margin = new Padding(4);
            btnSorting.Name = "btnSorting";
            btnSorting.Size = new Size(161, 30);
            btnSorting.TabIndex = 19;
            btnSorting.Text = "Sorting >>>";
            btnSorting.UseVisualStyleBackColor = false;
            btnSorting.Click += btnSorting_Click_1;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 636);
            Controls.Add(btnSorting);
            Controls.Add(btnAnagrams);
            Controls.Add(btnSecondLargest);
            Controls.Add(btnSwap);
            Controls.Add(btnFibonacci);
            Controls.Add(btnReverseArray);
            Controls.Add(btnRemoveOccurrences);
            Controls.Add(btnSumArray);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFactorialInteger);
            Controls.Add(btnMatchingNumbers);
            Controls.Add(btnPrimeNumber);
            Controls.Add(btnVowelCons);
            Controls.Add(Occurences);
            Controls.Add(btnPal);
            Controls.Add(label1);
            Controls.Add(btnRevStr);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomePage";
            Text = "Home ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRevStr;
        private Label label1;
        private Button btnPal;
        private Button Occurences;
        private Button btnVowelCons;
        private Button btnFactorialInteger;
        private Button btnMatchingNumbers;
        private Button btnPrimeNumber;
        private Label label2;
        private Label label3;
        private Button btnSumArray;
        private Button btnRemoveOccurrences;
        private Button btnReverseArray;
        private Button btnSwap;
        private Button btnFibonacci;
        private Button btnSecondLargest;
        private Button btnAnagrams;
        private Button btnSorting;
    }
}