﻿namespace SoftwareDevelopment
{
    partial class RemoveOccurrences
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
            textBoxRemLtr = new TextBox();
            label4 = new Label();
            textBoxRepLtr = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(157, 351);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 45);
            btnSubmit.TabIndex = 27;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(294, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 45);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.Location = new Point(340, 264);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(59, 21);
            outputLabel.TabIndex = 25;
            outputLabel.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(158, 264);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 24;
            label3.Text = "Output";
            // 
            // btnViewCode
            // 
            btnViewCode.BackColor = Color.DodgerBlue;
            btnViewCode.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCode.Location = new Point(417, 351);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(111, 45);
            btnViewCode.TabIndex = 23;
            btnViewCode.Text = "View Code";
            btnViewCode.UseVisualStyleBackColor = false;
            btnViewCode.Click += btnViewCode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(552, 351);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 45);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtString
            // 
            txtString.Location = new Point(340, 125);
            txtString.Name = "txtString";
            txtString.Size = new Size(265, 23);
            txtString.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 127);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 20;
            label2.Text = "Enter some text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 54);
            label1.Name = "label1";
            label1.Size = new Size(472, 23);
            label1.TabIndex = 19;
            label1.Text = "Remove and replace characters in string";
            // 
            // textBoxRemLtr
            // 
            textBoxRemLtr.Location = new Point(340, 169);
            textBoxRemLtr.Name = "textBoxRemLtr";
            textBoxRemLtr.Size = new Size(47, 23);
            textBoxRemLtr.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(158, 171);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 28;
            label4.Text = "Remove letter";
            // 
            // textBoxRepLtr
            // 
            textBoxRepLtr.Location = new Point(340, 208);
            textBoxRepLtr.Name = "textBoxRepLtr";
            textBoxRepLtr.Size = new Size(47, 23);
            textBoxRepLtr.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(158, 210);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 30;
            label5.Text = "Replace letter";
            // 
            // RemoveOccurrences
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxRepLtr);
            Controls.Add(label5);
            Controls.Add(textBoxRemLtr);
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
            Name = "RemoveOccurrences";
            Text = "RemoveOccurrences";
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
        private TextBox textBoxRemLtr;
        private Label label4;
        private TextBox textBoxRepLtr;
        private Label label5;
    }
}