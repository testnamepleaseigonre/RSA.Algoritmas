
namespace RSA.Algoritmas
{
    partial class Form1
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
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DecryptedTextBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(85, 85);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(171, 20);
            this.PTextBox.TabIndex = 0;
            // 
            // QTextBox
            // 
            this.QTextBox.Location = new System.Drawing.Point(85, 111);
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(171, 20);
            this.QTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "( p ) value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "( q ) value:";
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(65, 137);
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.Size = new System.Drawing.Size(375, 20);
            this.TextTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "RSA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Encrypted text:";
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Location = new System.Drawing.Point(112, 203);
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(375, 20);
            this.EncryptedTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Decrypted text:";
            // 
            // DecryptedTextBox
            // 
            this.DecryptedTextBox.Location = new System.Drawing.Point(112, 229);
            this.DecryptedTextBox.Name = "DecryptedTextBox";
            this.DecryptedTextBox.Size = new System.Drawing.Size(375, 20);
            this.DecryptedTextBox.TabIndex = 9;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(284, 163);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 11;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(365, 163);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 12;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 271);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DecryptedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.PTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DecryptedTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
    }
}

