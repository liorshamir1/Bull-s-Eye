﻿namespace UI
{
    public partial class FormGameSettings
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
            this.NumberOfGuessesButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberOfGuessesButton
            // 
            this.NumberOfGuessesButton.Location = new System.Drawing.Point(12, 12);
            this.NumberOfGuessesButton.Name = "NumberOfGuessesButton";
            this.NumberOfGuessesButton.Size = new System.Drawing.Size(199, 23);
            this.NumberOfGuessesButton.TabIndex = 0;
            this.NumberOfGuessesButton.Text = "Number of chances : 4";
            this.NumberOfGuessesButton.UseVisualStyleBackColor = true;
            this.NumberOfGuessesButton.Click += new System.EventHandler(this.NumberOfGuessesButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(136, 74);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 109);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NumberOfGuessesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NumberOfGuessesButton;
        private System.Windows.Forms.Button StartButton;
    }
}