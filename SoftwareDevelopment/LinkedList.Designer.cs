namespace SoftwareDevelopment
{
    partial class LinkedList
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
            textString2 = new TextBox();
            label5 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            outputLabel = new Label();
            label3 = new Label();
            btnViewCode = new Button();
            btnBack = new Button();
            textString1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textString3 = new TextBox();
            label4 = new Label();
            RevOutputLabel = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textString2
            // 
            textString2.Location = new Point(500, 203);
            textString2.Name = "textString2";
            textString2.Size = new Size(265, 23);
            textString2.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(318, 205);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 51;
            label5.Text = "Enter second word";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(318, 420);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 45);
            btnSubmit.TabIndex = 50;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(455, 420);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 45);
            btnClear.TabIndex = 49;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.Location = new Point(500, 311);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(59, 21);
            outputLabel.TabIndex = 48;
            outputLabel.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(318, 311);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 47;
            label3.Text = "Original List";
            // 
            // btnViewCode
            // 
            btnViewCode.BackColor = Color.DodgerBlue;
            btnViewCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCode.Location = new Point(578, 420);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(111, 45);
            btnViewCode.TabIndex = 46;
            btnViewCode.Text = "View Code";
            btnViewCode.UseVisualStyleBackColor = false;
            btnViewCode.Click += btnViewCode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(713, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 45);
            btnBack.TabIndex = 45;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // textString1
            // 
            textString1.Location = new Point(500, 152);
            textString1.Name = "textString1";
            textString1.Size = new Size(265, 23);
            textString1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(318, 154);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 43;
            label2.Text = "Enter first word";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(426, 81);
            label1.Name = "label1";
            label1.Size = new Size(226, 23);
            label1.TabIndex = 42;
            label1.Text = "Reverse Linked List";
            // 
            // textString3
            // 
            textString3.Location = new Point(500, 251);
            textString3.Name = "textString3";
            textString3.Size = new Size(265, 23);
            textString3.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(318, 253);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 53;
            label4.Text = "Enter third word";
            // 
            // RevOutputLabel
            // 
            RevOutputLabel.AutoSize = true;
            RevOutputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RevOutputLabel.Location = new Point(500, 358);
            RevOutputLabel.Name = "RevOutputLabel";
            RevOutputLabel.Size = new Size(59, 21);
            RevOutputLabel.TabIndex = 56;
            RevOutputLabel.Text = "Output";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(318, 358);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 55;
            label7.Text = "Reversed List";
            // 
            // LinkedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 596);
            Controls.Add(RevOutputLabel);
            Controls.Add(label7);
            Controls.Add(textString3);
            Controls.Add(label4);
            Controls.Add(textString2);
            Controls.Add(label5);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(outputLabel);
            Controls.Add(label3);
            Controls.Add(btnViewCode);
            Controls.Add(btnBack);
            Controls.Add(textString1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LinkedList";
            Text = "LinkedList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textString2;
        private Label label5;
        private Button btnSubmit;
        private Button btnClear;
        private Label outputLabel;
        private Label label3;
        private Button btnViewCode;
        private Button btnBack;
        private TextBox textString1;
        private Label label2;
        private Label label1;
        private TextBox textString3;
        private Label label4;
        private Label RevOutputLabel;
        private Label label7;
    }
}