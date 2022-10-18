using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesLogic;

namespace UI
{
    public partial class FormColors : Form
    {
        private GamesLogic.eColors m_ColorValue;

        public FormColors()
        {
            InitializeComponent();
        }

        public GamesLogic.eColors ColorValue 
        {
            get
            {
                return this.m_ColorValue;
            }

            set
            {
                this.m_ColorValue = value;
            }
        }

        private void buttonColorPink_Click(object sender, EventArgs e)
        {
            ColorValue = eColors.Pink;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonColorGreen_Click(object sender, EventArgs e)
        {
            ColorValue = eColors.Green;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonColorLightBlue_Click(object sender, EventArgs e)
        {
            ColorValue = eColors.LightBlue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonColorBlue_Click(object sender, EventArgs e)
        {
            ColorValue = eColors.Blue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonColorYellow_Click(object sender, EventArgs e)
        {
            ColorValue = eColors.Yellow;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonColorBrown_Click(object sender, EventArgs e)
        {
            ColorValue = eColors.Brown;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonColorWhite_Click(object sender, EventArgs e)
        {
            ColorValue = eColors.White;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonColorRed_Click(object sender, EventArgs e)
        {
            ColorValue = eColors.Red;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
