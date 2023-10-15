namespace SoftwareDevelopment
{
    partial class ReverseAString
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 48);
            label1.Name = "label1";
            label1.Size = new Size(195, 23);
            label1.TabIndex = 0;
            label1.Text = "Reverse a string";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 135);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter some text";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(210, 344);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(535, 344);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 4;
            button2.Text = "View Code";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(150, 223);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 5;
            label3.Text = "Reversed Text";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 228);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // button3
            // 
            button3.Location = new Point(366, 344);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ReverseAString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReverseAString";
            Text = "ReverseAString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Button button3;
    }
}