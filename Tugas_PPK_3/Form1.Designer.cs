﻿namespace Tugas_PPK_3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Open_Button = new System.Windows.Forms.Button();
            this.FileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(51, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(417, 290);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Open_Button
            // 
            this.Open_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Open_Button.Location = new System.Drawing.Point(195, 379);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(109, 40);
            this.Open_Button.TabIndex = 1;
            this.Open_Button.Text = "Open";
            this.Open_Button.UseVisualStyleBackColor = true;
            this.Open_Button.Click += new System.EventHandler(this.Open_Button_Click);
            // 
            // FileDialog1
            // 
            this.FileDialog1.FileName = "FileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 482);
            this.Controls.Add(this.Open_Button);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Open_Button;
        private System.Windows.Forms.OpenFileDialog FileDialog1;
    }
}

