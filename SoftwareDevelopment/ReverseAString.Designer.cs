namespace SoftwareDevelopment
{
    partial class txtRevStringOutput
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
            txtString = new TextBox();
            btnBack = new Button();
            btnViewCode = new Button();
            label3 = new Label();
            btnClear = new Button();
            btnSubmit = new Button();
            outputLabel = new Label();
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
            // txtString
            // 
            txtString.Location = new Point(332, 133);
            txtString.Name = "txtString";
            txtString.Size = new Size(265, 23);
            txtString.TabIndex = 2;
            txtString.TextChanged += txtString_TextChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(179, 344);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button1_Click;
            // 
            // btnViewCode
            // 
            btnViewCode.Location = new Point(535, 344);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(111, 23);
            btnViewCode.TabIndex = 4;
            btnViewCode.Text = "View Code";
            btnViewCode.UseVisualStyleBackColor = true;
            btnViewCode.Click += btnViewCode_Click;
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
            // btnClear
            // 
            btnClear.Location = new Point(416, 344);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button3_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(309, 344);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.Location = new Point(332, 228);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(59, 21);
            outputLabel.TabIndex = 6;
            outputLabel.Text = "Output";
            // 
            // txtRevStringOutput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(outputLabel);
            Controls.Add(label3);
            Controls.Add(btnViewCode);
            Controls.Add(btnBack);
            Controls.Add(txtString);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "txtRevStringOutput";
            Text = "ReverseAString";
            Load += ReverseAString_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtString;
        private Button btnBack;
        private Button btnViewCode;
        private Label label3;
        private Button btnClear;
        private Button btnSubmit;
        private Label outputLabel;
    }
}