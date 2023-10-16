namespace SoftwareDevelopment
{
    partial class Palindrome
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
            btnSubmit = new Button();
            btnClear = new Button();
            outputLabel = new Label();
            label3 = new Label();
            btnViewCode = new Button();
            btnBack = new Button();
            txtString = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(151, 351);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 45);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(288, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 45);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.Location = new Point(334, 264);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(59, 21);
            outputLabel.TabIndex = 15;
            outputLabel.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(152, 264);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 14;
            label3.Text = "Palindrome?";
            // 
            // btnViewCode
            // 
            btnViewCode.BackColor = Color.DodgerBlue;
            btnViewCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCode.Location = new Point(411, 351);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(111, 45);
            btnViewCode.TabIndex = 13;
            btnViewCode.Text = "View Code";
            btnViewCode.UseVisualStyleBackColor = false;
            btnViewCode.Click += btnViewCode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(546, 351);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 45);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtString
            // 
            txtString.Location = new Point(334, 174);
            txtString.Name = "txtString";
            txtString.Size = new Size(265, 23);
            txtString.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 176);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 10;
            label2.Text = "Enter some text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 55);
            label1.Name = "label1";
            label1.Size = new Size(425, 23);
            label1.TabIndex = 9;
            label1.Text = "Determine if a string is a Palindrome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(122, 113);
            label4.Name = "label4";
            label4.Size = new Size(544, 18);
            label4.TabIndex = 18;
            label4.Text = "A Palindrome is a string that stays the same when the characters are reversed";
            // 
            // Palindrome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(outputLabel);
            Controls.Add(label3);
            Controls.Add(btnViewCode);
            Controls.Add(btnBack);
            Controls.Add(txtString);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Palindrome";
            Text = "Palindrome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnClear;
        private Label outputLabel;
        private Label label3;
        private Button btnViewCode;
        private Button btnBack;
        private TextBox txtString;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}