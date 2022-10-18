namespace UI
{
    public partial class FormColors
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
            this.buttonColorPink = new System.Windows.Forms.Button();
            this.buttonColorRed = new System.Windows.Forms.Button();
            this.buttonColorGreen = new System.Windows.Forms.Button();
            this.buttonColorLightBlue = new System.Windows.Forms.Button();
            this.buttonColorBlue = new System.Windows.Forms.Button();
            this.buttonColorYellow = new System.Windows.Forms.Button();
            this.buttonColorBrown = new System.Windows.Forms.Button();
            this.buttonColorWhite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColorPink
            // 
            this.buttonColorPink.BackColor = System.Drawing.Color.Pink;
            this.buttonColorPink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonColorPink.Location = new System.Drawing.Point(12, 12);
            this.buttonColorPink.Name = "buttonColorPink";
            this.buttonColorPink.Size = new System.Drawing.Size(50, 50);
            this.buttonColorPink.TabIndex = 0;
            this.buttonColorPink.UseVisualStyleBackColor = false;
            this.buttonColorPink.Click += new System.EventHandler(this.buttonColorPink_Click);
            // 
            // buttonColorRed
            // 
            this.buttonColorRed.BackColor = System.Drawing.Color.Red;
            this.buttonColorRed.Location = new System.Drawing.Point(68, 12);
            this.buttonColorRed.Name = "buttonColorRed";
            this.buttonColorRed.Size = new System.Drawing.Size(50, 50);
            this.buttonColorRed.TabIndex = 1;
            this.buttonColorRed.UseVisualStyleBackColor = false;
            this.buttonColorRed.Click += new System.EventHandler(this.buttonColorRed_Click);
            // 
            // buttonColorGreen
            // 
            this.buttonColorGreen.BackColor = System.Drawing.Color.Green;
            this.buttonColorGreen.Location = new System.Drawing.Point(124, 12);
            this.buttonColorGreen.Name = "buttonColorGreen";
            this.buttonColorGreen.Size = new System.Drawing.Size(50, 50);
            this.buttonColorGreen.TabIndex = 2;
            this.buttonColorGreen.UseVisualStyleBackColor = false;
            this.buttonColorGreen.Click += new System.EventHandler(this.buttonColorGreen_Click);
            // 
            // buttonColorLightBlue
            // 
            this.buttonColorLightBlue.BackColor = System.Drawing.Color.LightBlue;
            this.buttonColorLightBlue.Location = new System.Drawing.Point(180, 12);
            this.buttonColorLightBlue.Name = "buttonColorLightBlue";
            this.buttonColorLightBlue.Size = new System.Drawing.Size(50, 50);
            this.buttonColorLightBlue.TabIndex = 3;
            this.buttonColorLightBlue.UseVisualStyleBackColor = false;
            this.buttonColorLightBlue.Click += new System.EventHandler(this.buttonColorLightBlue_Click);
            // 
            // buttonColorBlue
            // 
            this.buttonColorBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonColorBlue.Location = new System.Drawing.Point(12, 68);
            this.buttonColorBlue.Name = "buttonColorBlue";
            this.buttonColorBlue.Size = new System.Drawing.Size(50, 50);
            this.buttonColorBlue.TabIndex = 4;
            this.buttonColorBlue.UseVisualStyleBackColor = false;
            this.buttonColorBlue.Click += new System.EventHandler(this.buttonColorBlue_Click);
            // 
            // buttonColorYellow
            // 
            this.buttonColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonColorYellow.Location = new System.Drawing.Point(68, 68);
            this.buttonColorYellow.Name = "buttonColorYellow";
            this.buttonColorYellow.Size = new System.Drawing.Size(50, 50);
            this.buttonColorYellow.TabIndex = 5;
            this.buttonColorYellow.UseVisualStyleBackColor = false;
            this.buttonColorYellow.Click += new System.EventHandler(this.buttonColorYellow_Click);
            // 
            // buttonColorBrown
            // 
            this.buttonColorBrown.BackColor = System.Drawing.Color.Brown;
            this.buttonColorBrown.Location = new System.Drawing.Point(124, 68);
            this.buttonColorBrown.Name = "buttonColorBrown";
            this.buttonColorBrown.Size = new System.Drawing.Size(50, 50);
            this.buttonColorBrown.TabIndex = 6;
            this.buttonColorBrown.UseVisualStyleBackColor = false;
            this.buttonColorBrown.Click += new System.EventHandler(this.buttonColorBrown_Click);
            // 
            // buttonColorWhite
            // 
            this.buttonColorWhite.BackColor = System.Drawing.Color.White;
            this.buttonColorWhite.Location = new System.Drawing.Point(180, 68);
            this.buttonColorWhite.Name = "buttonColorWhite";
            this.buttonColorWhite.Size = new System.Drawing.Size(50, 50);
            this.buttonColorWhite.TabIndex = 7;
            this.buttonColorWhite.UseVisualStyleBackColor = false;
            this.buttonColorWhite.Click += new System.EventHandler(this.buttonColorWhite_Click);
            // 
            // FormColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(249, 135);
            this.Controls.Add(this.buttonColorWhite);
            this.Controls.Add(this.buttonColorBrown);
            this.Controls.Add(this.buttonColorYellow);
            this.Controls.Add(this.buttonColorBlue);
            this.Controls.Add(this.buttonColorLightBlue);
            this.Controls.Add(this.buttonColorGreen);
            this.Controls.Add(this.buttonColorRed);
            this.Controls.Add(this.buttonColorPink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick A Color:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonColorPink;
        private System.Windows.Forms.Button buttonColorRed;
        private System.Windows.Forms.Button buttonColorGreen;
        private System.Windows.Forms.Button buttonColorLightBlue;
        private System.Windows.Forms.Button buttonColorBlue;
        private System.Windows.Forms.Button buttonColorYellow;
        private System.Windows.Forms.Button buttonColorBrown;
        private System.Windows.Forms.Button buttonColorWhite;
    }
}