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
            SuspendLayout();
            // 
            // btnRevStr
            // 
            btnRevStr.Location = new Point(96, 132);
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
            label1.Location = new Point(267, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(329, 23);
            label1.TabIndex = 1;
            label1.Text = "Select an algorithm to test";
            // 
            // btnPal
            // 
            btnPal.Location = new Point(329, 132);
            btnPal.Name = "btnPal";
            btnPal.Size = new Size(161, 59);
            btnPal.TabIndex = 2;
            btnPal.Text = "Palindrome";
            btnPal.UseVisualStyleBackColor = true;
            btnPal.Click += btnPal_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
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
    }
}