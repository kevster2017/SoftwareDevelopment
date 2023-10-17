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
            button1 = new Button();
            button2 = new Button();
            btnPrimeNumber = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            btnSumArray = new Button();
            SuspendLayout();
            // 
            // btnRevStr
            // 
            btnRevStr.Location = new Point(96, 177);
            btnRevStr.Margin = new Padding(4);
            btnRevStr.Name = "btnRevStr";
            btnRevStr.Size = new Size(188, 59);
            btnRevStr.TabIndex = 0;
            btnRevStr.Text = "Reverse a string";
            btnRevStr.UseVisualStyleBackColor = true;
            btnRevStr.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(329, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(329, 23);
            label1.TabIndex = 1;
            label1.Text = "Select an algorithm to test";
            // 
            // btnPal
            // 
            btnPal.Location = new Point(329, 177);
            btnPal.Name = "btnPal";
            btnPal.Size = new Size(161, 59);
            btnPal.TabIndex = 2;
            btnPal.Text = "Palindrome";
            btnPal.UseVisualStyleBackColor = true;
            btnPal.Click += btnPal_Click;
            // 
            // Occurences
            // 
            Occurences.Location = new Point(546, 177);
            Occurences.Name = "Occurences";
            Occurences.Size = new Size(161, 59);
            Occurences.TabIndex = 3;
            Occurences.Text = "Occurrences";
            Occurences.UseVisualStyleBackColor = true;
            Occurences.Click += button1_Click_1;
            // 
            // btnVowelCons
            // 
            btnVowelCons.Location = new Point(744, 177);
            btnVowelCons.Name = "btnVowelCons";
            btnVowelCons.Size = new Size(151, 59);
            btnVowelCons.TabIndex = 4;
            btnVowelCons.Text = "Vowels and Consonants";
            btnVowelCons.UseVisualStyleBackColor = true;
            btnVowelCons.Click += btnVowelCons_Click;
            // 
            // button1
            // 
            button1.Location = new Point(744, 318);
            button1.Name = "button1";
            button1.Size = new Size(151, 59);
            button1.TabIndex = 8;
            button1.Text = "Vowels and Consonants";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(546, 318);
            button2.Name = "button2";
            button2.Size = new Size(161, 59);
            button2.TabIndex = 7;
            button2.Text = "Occurrences";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnPrimeNumber
            // 
            btnPrimeNumber.Location = new Point(329, 318);
            btnPrimeNumber.Name = "btnPrimeNumber";
            btnPrimeNumber.Size = new Size(161, 59);
            btnPrimeNumber.TabIndex = 6;
            btnPrimeNumber.Text = "Prime Number";
            btnPrimeNumber.UseVisualStyleBackColor = true;
            btnPrimeNumber.Click += btnPrimeNumber_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
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
            label3.Location = new Point(96, 270);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 10;
            label3.Text = "Numbers";
            // 
            // btnSumArray
            // 
            btnSumArray.Location = new Point(96, 318);
            btnSumArray.Margin = new Padding(4);
            btnSumArray.Name = "btnSumArray";
            btnSumArray.Size = new Size(188, 59);
            btnSumArray.TabIndex = 12;
            btnSumArray.Text = "Sum up array elements";
            btnSumArray.UseVisualStyleBackColor = true;
            btnSumArray.Click += btnSumArray_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnSumArray);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnPrimeNumber);
            Controls.Add(button4);
            Controls.Add(btnVowelCons);
            Controls.Add(Occurences);
            Controls.Add(btnPal);
            Controls.Add(label1);
            Controls.Add(btnRevStr);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRevStr;
        private Label label1;
        private Button btnPal;
        private Button Occurences;
        private Button btnVowelCons;
        private Button button1;
        private Button button2;
        private Button btnPrimeNumber;
        private Button button4;
        private Label label2;
        private Label label3;
        private Button btnSumArray;
    }
}