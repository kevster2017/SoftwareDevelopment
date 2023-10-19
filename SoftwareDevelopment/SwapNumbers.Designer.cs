namespace SoftwareDevelopment
{
    partial class SwapNumbers
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
            textBoxNum2 = new TextBox();
            label5 = new Label();
            textBoxNum1 = new TextBox();
            label4 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            outputLabel = new Label();
            label3 = new Label();
            btnViewCode = new Button();
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(471, 225);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(47, 23);
            textBoxNum2.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(289, 227);
            label5.Name = "label5";
            label5.Size = new Size(158, 21);
            label5.TabIndex = 43;
            label5.Text = "Enter second number";
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(471, 186);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(47, 23);
            textBoxNum1.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(289, 188);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 41;
            label4.Text = "Enter first number";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(279, 402);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 45);
            btnSubmit.TabIndex = 40;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(416, 402);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 45);
            btnClear.TabIndex = 39;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.Location = new Point(471, 281);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(59, 21);
            outputLabel.TabIndex = 38;
            outputLabel.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(289, 281);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 37;
            label3.Text = "Output";
            // 
            // btnViewCode
            // 
            btnViewCode.BackColor = Color.DodgerBlue;
            btnViewCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCode.Location = new Point(539, 402);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(111, 45);
            btnViewCode.TabIndex = 36;
            btnViewCode.Text = "View Code";
            btnViewCode.UseVisualStyleBackColor = false;
            btnViewCode.Click += btnViewCode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(674, 402);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 45);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(234, 98);
            label1.Name = "label1";
            label1.Size = new Size(588, 23);
            label1.TabIndex = 32;
            label1.Text = "Swap two numbers without using a third variable";
            // 
            // SwapNumbers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 553);
            Controls.Add(textBoxNum2);
            Controls.Add(label5);
            Controls.Add(textBoxNum1);
            Controls.Add(label4);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(outputLabel);
            Controls.Add(label3);
            Controls.Add(btnViewCode);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "SwapNumbers";
            Text = "SwapNumbers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNum2;
        private Label label5;
        private TextBox textBoxNum1;
        private Label label4;
        private Button btnSubmit;
        private Button btnClear;
        private Label outputLabel;
        private Label label3;
        private Button btnViewCode;
        private Button btnBack;
        private Label label1;
    }
}