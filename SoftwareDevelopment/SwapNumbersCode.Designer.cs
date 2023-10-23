namespace SoftwareDevelopment
{
    partial class SwapNumbersCode
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
            label8 = new Label();
            btnBack = new Button();
            btnClear = new Button();
            btnDisplay = new Button();
            textBoxCode = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(161, 424);
            label8.Name = "label8";
            label8.Size = new Size(111, 18);
            label8.TabIndex = 35;
            label8.Text = "* Display result";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(441, 485);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 40);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(281, 485);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 40);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(0, 192, 0);
            btnDisplay.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisplay.Location = new Point(131, 485);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(118, 40);
            btnDisplay.TabIndex = 32;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // textBoxCode
            // 
            textBoxCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCode.Location = new Point(600, 181);
            textBoxCode.Multiline = true;
            textBoxCode.Name = "textBoxCode";
            textBoxCode.ScrollBars = ScrollBars.Vertical;
            textBoxCode.Size = new Size(376, 344);
            textBoxCode.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(161, 385);
            label7.Name = "label7";
            label7.Size = new Size(190, 18);
            label7.TabIndex = 30;
            label7.Text = "* Set num2 = num2 - num1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(161, 346);
            label6.Name = "label6";
            label6.Size = new Size(194, 18);
            label6.TabIndex = 29;
            label6.Text = "*  Set num1 = num2 - num1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(161, 310);
            label5.Name = "label5";
            label5.Size = new Size(194, 18);
            label5.TabIndex = 28;
            label5.Text = "* Set num2 = num1 + num2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(161, 276);
            label4.Name = "label4";
            label4.Size = new Size(243, 18);
            label4.TabIndex = 27;
            label4.Text = "* Declare second number variable";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 239);
            label3.Name = "label3";
            label3.Size = new Size(217, 18);
            label3.TabIndex = 26;
            label3.Text = "* Declare first number variable";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(128, 181);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 23);
            label2.TabIndex = 25;
            label2.Text = "How to swap two numbers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(588, 23);
            label1.TabIndex = 24;
            label1.Text = "Swap two numbers without using a third variable";
            // 
            // SwapNumbersCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 615);
            Controls.Add(label8);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(textBoxCode);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SwapNumbersCode";
            Text = "Declare second number variable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Button btnBack;
        private Button btnClear;
        private Button btnDisplay;
        private TextBox textBoxCode;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}