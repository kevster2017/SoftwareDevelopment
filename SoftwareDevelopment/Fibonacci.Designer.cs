namespace SoftwareDevelopment
{
    partial class Fibonacci
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
            textBoxNum = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(284, 432);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 45);
            btnSubmit.TabIndex = 45;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(421, 432);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 45);
            btnClear.TabIndex = 44;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.Location = new Point(496, 321);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(59, 21);
            outputLabel.TabIndex = 43;
            outputLabel.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(314, 321);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 42;
            label3.Text = "Fibonacci Series";
            // 
            // btnViewCode
            // 
            btnViewCode.BackColor = Color.DodgerBlue;
            btnViewCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCode.Location = new Point(544, 432);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(111, 45);
            btnViewCode.TabIndex = 41;
            btnViewCode.Text = "View Code";
            btnViewCode.UseVisualStyleBackColor = false;
            btnViewCode.Click += btnViewCode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(679, 432);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 45);
            btnBack.TabIndex = 40;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(496, 231);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(37, 23);
            textBoxNum.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(314, 233);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 38;
            label2.Text = "Enter a number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(302, 134);
            label1.Name = "label1";
            label1.Size = new Size(440, 23);
            label1.TabIndex = 37;
            label1.Text = "Print Fibonacci Series using recursion";
            // 
            // Fibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 613);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(outputLabel);
            Controls.Add(label3);
            Controls.Add(btnViewCode);
            Controls.Add(btnBack);
            Controls.Add(textBoxNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Fibonacci";
            Text = "Fibonacci";
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
        private TextBox textBoxNum;
        private Label label2;
        private Label label1;
    }
}