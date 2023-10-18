namespace SoftwareDevelopment
{
    partial class ReverseArrayCode
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
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(931, 162);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 344);
            vScrollBar1.TabIndex = 75;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(114, 289);
            label8.Name = "label8";
            label8.Size = new Size(309, 18);
            label8.TabIndex = 74;
            label8.Text = "* Display result using string.Join(\", \", array2)";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(393, 466);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 40);
            btnBack.TabIndex = 73;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(233, 466);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 40);
            btnClear.TabIndex = 72;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(0, 192, 0);
            btnDisplay.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisplay.Location = new Point(83, 466);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(118, 40);
            btnDisplay.TabIndex = 71;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // textBoxCode
            // 
            textBoxCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCode.Location = new Point(552, 159);
            textBoxCode.Multiline = true;
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(376, 344);
            textBoxCode.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(113, 218);
            label4.Name = "label4";
            label4.Size = new Size(112, 18);
            label4.TabIndex = 66;
            label4.Text = "* Declare array";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(113, 253);
            label3.Name = "label3";
            label3.Size = new Size(433, 18);
            label3.TabIndex = 65;
            label3.Text = "* Declare a second array and set to array.Reverse().ToArray();";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 23);
            label2.TabIndex = 64;
            label2.Text = "How to reverse an array";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(393, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 23);
            label1.TabIndex = 63;
            label1.Text = "Reverse an array";
            // 
            // ReverseArrayCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 573);
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
            Name = "ReverseArrayCode";
            Text = "ReverseArrayCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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