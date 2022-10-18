namespace UI
{
    public partial class FormGame
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
            this.ComputerGuessButton1 = new System.Windows.Forms.Button();
            this.ComputerGuessButton2 = new System.Windows.Forms.Button();
            this.ComputerGuessButton3 = new System.Windows.Forms.Button();
            this.ComputerGuessButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComputerGuessButton1
            // 
            this.ComputerGuessButton1.BackColor = System.Drawing.Color.Black;
            this.ComputerGuessButton1.Location = new System.Drawing.Point(17, 12);
            this.ComputerGuessButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComputerGuessButton1.Name = "ComputerGuessButton1";
            this.ComputerGuessButton1.Padding = new System.Windows.Forms.Padding(1);
            this.ComputerGuessButton1.Size = new System.Drawing.Size(55, 59);
            this.ComputerGuessButton1.TabIndex = 0;
            this.ComputerGuessButton1.UseVisualStyleBackColor = false;
            // 
            // ComputerGuessButton2
            // 
            this.ComputerGuessButton2.BackColor = System.Drawing.Color.Black;
            this.ComputerGuessButton2.Location = new System.Drawing.Point(82, 12);
            this.ComputerGuessButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComputerGuessButton2.Name = "ComputerGuessButton2";
            this.ComputerGuessButton2.Padding = new System.Windows.Forms.Padding(1);
            this.ComputerGuessButton2.Size = new System.Drawing.Size(55, 59);
            this.ComputerGuessButton2.TabIndex = 1;
            this.ComputerGuessButton2.UseVisualStyleBackColor = false;
            // 
            // ComputerGuessButton3
            // 
            this.ComputerGuessButton3.BackColor = System.Drawing.Color.Black;
            this.ComputerGuessButton3.Location = new System.Drawing.Point(148, 12);
            this.ComputerGuessButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComputerGuessButton3.Name = "ComputerGuessButton3";
            this.ComputerGuessButton3.Size = new System.Drawing.Size(55, 59);
            this.ComputerGuessButton3.TabIndex = 2;
            this.ComputerGuessButton3.UseVisualStyleBackColor = false;
            // 
            // ComputerGuessButton4
            // 
            this.ComputerGuessButton4.BackColor = System.Drawing.Color.Black;
            this.ComputerGuessButton4.Location = new System.Drawing.Point(214, 12);
            this.ComputerGuessButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComputerGuessButton4.Name = "ComputerGuessButton4";
            this.ComputerGuessButton4.Padding = new System.Windows.Forms.Padding(1);
            this.ComputerGuessButton4.Size = new System.Drawing.Size(55, 59);
            this.ComputerGuessButton4.TabIndex = 3;
            this.ComputerGuessButton4.UseVisualStyleBackColor = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(327, 857);
            this.Controls.Add(this.ComputerGuessButton4);
            this.Controls.Add(this.ComputerGuessButton3);
            this.Controls.Add(this.ComputerGuessButton2);
            this.Controls.Add(this.ComputerGuessButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComputerGuessButton1;
        private System.Windows.Forms.Button ComputerGuessButton2;
        private System.Windows.Forms.Button ComputerGuessButton3;
        private System.Windows.Forms.Button ComputerGuessButton4;
    }
}