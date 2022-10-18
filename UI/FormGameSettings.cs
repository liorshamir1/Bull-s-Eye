using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormGameSettings : Form
    {
        private readonly int r_MaxNumberOfTries = 10, r_MinNumberOfTries = 4;
        private int m_NumberOfChances = 4;

        public int NumberOfChances
        {
            get
            {
                return this.m_NumberOfChances;
            }

            set
            {
                this.m_NumberOfChances = value;
            }
        }

        public FormGameSettings()
        {
            InitializeComponent();
        }

        private void NumberOfGuessesButton_Click(object sender, EventArgs e)
        {
            if (NumberOfChances < r_MaxNumberOfTries)
            {
                NumberOfGuessesButton.Text = string.Format("Number of chances : {0}", ++NumberOfChances);
            }
            else
            {
                NumberOfChances = r_MinNumberOfTries;
                NumberOfGuessesButton.Text = string.Format("Number of chances : {0}", NumberOfChances);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {   
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
