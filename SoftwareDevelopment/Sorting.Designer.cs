namespace SoftwareDevelopment
{
    partial class Sorting
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
            label2 = new Label();
            btnLinkedList = new Button();
            btnBinary = new Button();
            btnInsertionSort = new Button();
            label1 = new Label();
            btnBubbleSort = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(171, 147);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 15;
            label2.Text = "Sorting";
            // 
            // btnLinkedList
            // 
            btnLinkedList.BackColor = Color.FromArgb(128, 255, 128);
            btnLinkedList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLinkedList.Location = new Point(819, 198);
            btnLinkedList.Name = "btnLinkedList";
            btnLinkedList.Size = new Size(151, 59);
            btnLinkedList.TabIndex = 14;
            btnLinkedList.Text = "Reverse Linked List";
            btnLinkedList.UseVisualStyleBackColor = false;
            btnLinkedList.Click += btnLinkedList_Click;
            // 
            // btnBinary
            // 
            btnBinary.BackColor = Color.FromArgb(128, 255, 128);
            btnBinary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBinary.Location = new Point(621, 198);
            btnBinary.Name = "btnBinary";
            btnBinary.Size = new Size(161, 59);
            btnBinary.TabIndex = 13;
            btnBinary.Text = "Binary Search";
            btnBinary.UseVisualStyleBackColor = false;
            btnBinary.Click += btnBinary_Click;
            // 
            // btnInsertionSort
            // 
            btnInsertionSort.BackColor = Color.FromArgb(128, 255, 128);
            btnInsertionSort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertionSort.Location = new Point(404, 198);
            btnInsertionSort.Name = "btnInsertionSort";
            btnInsertionSort.Size = new Size(161, 59);
            btnInsertionSort.TabIndex = 12;
            btnInsertionSort.Text = "Insertion Sort";
            btnInsertionSort.UseVisualStyleBackColor = false;
            btnInsertionSort.Click += btnInsertionSort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(404, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(329, 23);
            label1.TabIndex = 11;
            label1.Text = "Select an algorithm to test";
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.BackColor = Color.FromArgb(128, 255, 128);
            btnBubbleSort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBubbleSort.Location = new Point(171, 198);
            btnBubbleSort.Margin = new Padding(4);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(188, 59);
            btnBubbleSort.TabIndex = 10;
            btnBubbleSort.Text = "Bubble Sort";
            btnBubbleSort.UseVisualStyleBackColor = false;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(192, 255, 255);
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.Black;
            btnHome.Location = new Point(171, 454);
            btnHome.Margin = new Padding(4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(131, 33);
            btnHome.TabIndex = 16;
            btnHome.Text = "<<< Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // Sorting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 603);
            Controls.Add(btnHome);
            Controls.Add(label2);
            Controls.Add(btnLinkedList);
            Controls.Add(btnBinary);
            Controls.Add(btnInsertionSort);
            Controls.Add(label1);
            Controls.Add(btnBubbleSort);
            Name = "Sorting";
            Text = "Sorting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnLinkedList;
        private Button btnBinary;
        private Button btnInsertionSort;
        private Label label1;
        private Button btnBubbleSort;
        private Button btnHome;
    }
}