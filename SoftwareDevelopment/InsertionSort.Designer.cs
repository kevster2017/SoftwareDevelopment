namespace SoftwareDevelopment
{
    partial class InsertionSort
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
            label4 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            outputLabel = new Label();
            label3 = new Label();
            btnViewCode = new Button();
            btnBack = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(570, 236);
            label4.Name = "label4";
            label4.Size = new Size(219, 21);
            label4.TabIndex = 65;
            label4.Text = "{ 50, 99, 7, 83, 67, 1, 5, 15, 88 }";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(314, 437);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 45);
            btnSubmit.TabIndex = 64;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(451, 437);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 45);
            btnClear.TabIndex = 63;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.Location = new Point(574, 328);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(59, 21);
            outputLabel.TabIndex = 62;
            outputLabel.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(367, 328);
            label3.Name = "label3";
            label3.Size = new Size(163, 21);
            label3.TabIndex = 61;
            label3.Text = "Insertion Sorted Array";
            // 
            // btnViewCode
            // 
            btnViewCode.BackColor = Color.DodgerBlue;
            btnViewCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCode.Location = new Point(574, 437);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(111, 45);
            btnViewCode.TabIndex = 60;
            btnViewCode.Text = "View Code";
            btnViewCode.UseVisualStyleBackColor = false;
            btnViewCode.Click += btnViewCode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(709, 437);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 45);
            btnBack.TabIndex = 59;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(367, 236);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 58;
            label2.Text = "Original Array";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(314, 138);
            label1.Name = "label1";
            label1.Size = new Size(515, 23);
            label1.TabIndex = 57;
            label1.Text = "how to implement insertion sort algorithm";
            // 
            // InsertionSort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 621);
            Controls.Add(label4);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(outputLabel);
            Controls.Add(label3);
            Controls.Add(btnViewCode);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InsertionSort";
            Text = "InsertionSort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnSubmit;
        private Button btnClear;
        private Label outputLabel;
        private Label label3;
        private Button btnViewCode;
        private Button btnBack;
        private Label label2;
        private Label label1;
    }
}