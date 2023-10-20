namespace SoftwareDevelopment
{
    partial class InsertionSortCode
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
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            vScrollBar1 = new VScrollBar();
            label8 = new Label();
            btnBack = new Button();
            btnClear = new Button();
            btnDisplay = new Button();
            textBoxCode = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(161, 374);
            label11.Name = "label11";
            label11.Size = new Size(304, 18);
            label11.TabIndex = 150;
            label11.Text = "* Set arr[j] to arr[j-1] and set arr[j-1] as temp";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(161, 435);
            label9.Name = "label9";
            label9.Size = new Size(350, 18);
            label9.TabIndex = 149;
            label9.Text = "* Loop through sorted array and output each value";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(162, 404);
            label7.Name = "label7";
            label7.Size = new Size(102, 18);
            label7.TabIndex = 148;
            label7.Text = "* Decrement j";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(161, 306);
            label6.Name = "label6";
            label6.Size = new Size(215, 18);
            label6.TabIndex = 147;
            label6.Text = "* While j > 0 and arr[j-1] > arr[j]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(162, 341);
            label5.Name = "label5";
            label5.Size = new Size(270, 18);
            label5.TabIndex = 146;
            label5.Text = "* Create and set temp variable to arr[j]";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(979, 197);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 344);
            vScrollBar1.TabIndex = 145;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(162, 272);
            label8.Name = "label8";
            label8.Size = new Size(330, 18);
            label8.TabIndex = 144;
            label8.Text = "* Create int var j to store value of i from for loop";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(441, 501);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 40);
            btnBack.TabIndex = 143;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(281, 501);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 40);
            btnClear.TabIndex = 142;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(0, 192, 0);
            btnDisplay.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisplay.Location = new Point(131, 501);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(118, 40);
            btnDisplay.TabIndex = 141;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // textBoxCode
            // 
            textBoxCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCode.Location = new Point(600, 194);
            textBoxCode.Multiline = true;
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(376, 344);
            textBoxCode.TabIndex = 140;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(161, 201);
            label4.Name = "label4";
            label4.Size = new Size(133, 18);
            label4.TabIndex = 139;
            label4.Text = "* Declare an array";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 236);
            label3.Name = "label3";
            label3.Size = new Size(290, 18);
            label3.TabIndex = 138;
            label3.Text = "* First loop to loop through length of array";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(128, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 23);
            label2.TabIndex = 137;
            label2.Text = "How to implement Insertion Sort";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(515, 23);
            label1.TabIndex = 136;
            label1.Text = "How to implement Insertion Sort algorithm";
            // 
            // InsertionSortCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 623);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(vScrollBar1);
            Controls.Add(label8);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(textBoxCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InsertionSortCode";
            Text = "InsertionSortCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private VScrollBar vScrollBar1;
        private Label label8;
        private Button btnBack;
        private Button btnClear;
        private Button btnDisplay;
        private TextBox textBoxCode;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}