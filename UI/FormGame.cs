using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GamesLogic;

namespace UI
{
    public partial class FormGame : Form
    {
        private readonly int r_PanelHeight = 65, r_PanelWidth = 410,
            r_UserChoiceButtonHeight = 55, r_UserChoiceButtonWidth = 55,
            r_ArrowButtonHeight = 20, r_ArrowButtonWidth = 60,
            r_HintsButtonHeight = 25, r_HintsButtonWidth = 25;

        private int m_PanelX = 12, m_PanelY = 80,
            m_UserChoiceButtonX = 4, m_UserChoiceButtonY = 10,
            m_ArrowButtonX = 275, m_ArrowButtonY = 30,
            m_HintsButtonX = 355, m_HintsButtonY = 15,
            m_UserChoiceButtonCounter = 0, m_ArrowButtonCounter = 0, m_HintsButtonCounter = 0,
            m_PanelCounter = 0, m_CurrentPanel = 0, m_NumberOfGuesses;

        private GameLogic m_GameLogicVar = new GameLogic();
        private List<Panel> m_ListOfPanels = new List<Panel>();

        public FormGame(int i_NumberOfChances)
        {
            NumberOfGuesses = i_NumberOfChances;
            InitializeComponent();
            for (int i = 0; i < i_NumberOfChances; i++)
            {
                Panel panelOfButtons = CreatNewPanel();
                if (i != 0)
                {
                    panelOfButtons.Enabled = false;
                }

                Controls.Add(panelOfButtons);
            }

            this.ShowDialog();
        }

        public int UserChoiceButtonX
        {
            get
            {
                return this.m_UserChoiceButtonX;
            }

            set
            {
                this.m_UserChoiceButtonX = value;
            }
        }

        public int UserChoiceButtonY
        {
            get
            {
                return this.m_UserChoiceButtonY;
            }

            set
            {
                this.m_UserChoiceButtonY = value;
            }
        }

        public int ArrowButtonX
        {
            get
            {
                return this.m_ArrowButtonX;
            }

            set
            {
                this.m_ArrowButtonX = value;
            }
        }

        public int ArrowButtonY
        {
            get
            {
                return this.m_ArrowButtonY;
            }

            set
            {
                this.m_ArrowButtonY = value;
            }
        }

        public int HintsButtonX
        {
            get
            {
                return this.m_HintsButtonX;
            }

            set
            {
                this.m_HintsButtonX = value;
            }
        }

        public int HintsButtonY
        {
            get
            {
                return this.m_HintsButtonY;
            }

            set
            {
                this.m_HintsButtonY = value;
            }
        }

        public int UserChoiceButtonHeight
        {
            get
            {
                return this.r_UserChoiceButtonHeight;
            }
        }

        public int UserChoiceButtonWidth
        {
            get
            {
                return this.r_UserChoiceButtonWidth;
            }
        }

        public int ArrowButtonHeight
        {
            get
            {
                return this.r_ArrowButtonHeight;
            }
        }

        public int ArrowButtonWidth
        {
            get
            {
                return this.r_ArrowButtonWidth;
            }
        }

        public int HintsButtonHeight
        {
            get
            {
                return this.r_HintsButtonHeight;
            }
        }

        public int HintsButtonWidth
        {
            get
            {
                return this.r_HintsButtonWidth;
            }
        }

        public int PanelX
        {
            get
            {
                return this.m_PanelX;
            }

            set
            {
                this.m_PanelX = value;
            }
        }

        public int PanelY
        {
            get
            {
                return this.m_PanelY;
            }

            set
            {
                this.m_PanelY = value;
            }
        }

        public int PanelHeight
        {
            get
            {
                return this.r_PanelHeight;
            }
        }

        public int PanelWidth
        {
            get
            {
                return this.r_PanelWidth;
            }
        }

        public int UserChoiceButtonCounter
        {
            get
            {
                return this.m_UserChoiceButtonCounter;
            }

            set
            {
                this.m_UserChoiceButtonCounter = value;
            }
        }

        public int ArrowButtonCounter
        {
            get
            {
                return this.m_ArrowButtonCounter;
            }

            set
            {
                this.m_ArrowButtonCounter = value;
            }
        }

        public int HintsButtonCounter
        {
            get
            {
                return this.m_HintsButtonCounter;
            }

            set
            {
                this.m_HintsButtonCounter = value;
            }
        }

        public int PanelCounter
        {
            get
            {
                return this.m_PanelCounter;
            }

            set
            {
                this.m_PanelCounter = value;
            }
        }

        public GameLogic GameLogicVar { get => m_GameLogicVar; set => m_GameLogicVar = value; }

        public List<Panel> ListOfPanels { get => m_ListOfPanels; set => m_ListOfPanels = value; }

        public int CurrentPanel { get => m_CurrentPanel; set => m_CurrentPanel = value; }

        public int NumberOfGuesses { get => m_NumberOfGuesses; set => m_NumberOfGuesses = value; }

        public void RevealCompGuess()
        {
            ComputerGuessButton1.BackColor = Color.FromName(GameLogicVar.ComputerGuess[0].ToString());
            ComputerGuessButton2.BackColor = Color.FromName(GameLogicVar.ComputerGuess[1].ToString());
            ComputerGuessButton3.BackColor = Color.FromName(GameLogicVar.ComputerGuess[2].ToString());
            ComputerGuessButton4.BackColor = Color.FromName(GameLogicVar.ComputerGuess[3].ToString());
        }

        public Panel CreatNewPanel()
        {
            Panel panelOfButtons = new Panel
            {
                Location = new Point(PanelX, PanelY),
                Size = new Size(PanelWidth, PanelHeight),
                Name = string.Format("{0}", PanelCounter++)
            };

            ListOfPanels.Add(panelOfButtons);
            for (int i = 0; i < 4; i++)
            {
                Button UserChoiceButton = new Button
                {
                    Name = string.Format("{0}", UserChoiceButtonCounter++),
                    Size = new Size(UserChoiceButtonWidth, UserChoiceButtonHeight),
                    Location = new Point(UserChoiceButtonX, UserChoiceButtonY)
                };
                UserChoiceButton.Click += new EventHandler(UserChoiceButton_Click);
                panelOfButtons.Controls.Add(UserChoiceButton);
                UserChoiceButtonX += 66;
            }

            UserChoiceButtonCounter = 0;
            Button ArrowButton = new Button
            {
                Name = string.Format("{0}", ArrowButtonCounter++),
                Size = new Size(ArrowButtonWidth, ArrowButtonHeight),
                Location = new Point(ArrowButtonX, ArrowButtonY),
                Text = "-->",
                Enabled = false
            };

            ArrowButton.Click += new EventHandler(ArrowButton_Click);
            panelOfButtons.Controls.Add(ArrowButton);
            ArrowButtonCounter = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Button HintsButton = new Button
                    {
                        Name = string.Format("Hints{0}", HintsButtonCounter++),
                        Size = new Size(HintsButtonWidth, HintsButtonHeight),
                        Location = new Point(HintsButtonX, HintsButtonY),
                        Enabled = false
                    };
                    panelOfButtons.Controls.Add(HintsButton);
                    HintsButtonX += 25;
                }

                HintsButtonX = 355;
                HintsButtonY += 25;
            }

            PanelY += 65;
            HintsButtonCounter = 0;
            ResetStatsToDefault();
            return panelOfButtons;
        }

        private void UserChoiceButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            FormColors formColors = new FormColors();
            bool flagCancelDialog = false;
            DialogResult currentDialog = formColors.ShowDialog();
            if (currentDialog == DialogResult.OK)
            {
                while (!GameLogicVar.CheckIfExistsInArray(GameLogicVar.UserGuess, formColors.ColorValue, int.Parse(currentButton.Name))
                    && !flagCancelDialog)
                {
                    MessageBox.Show("You cant pick this color");
                    currentDialog = formColors.ShowDialog();
                    if (currentDialog == DialogResult.Cancel)
                    {
                        flagCancelDialog = true;
                    }
                }

                if (!flagCancelDialog)
                {
                    GameLogicVar.UserGuess[int.Parse(currentButton.Name)] = formColors.ColorValue;
                    currentButton.BackColor = Color.FromName(formColors.ColorValue.ToString());

                    if (GameLogicVar.CheckIfTheArrayIsFull())
                    {
                        foreach (Control control in ListOfPanels[CurrentPanel].Controls)
                        {
                            if (control.Text == "-->")
                            {
                                control.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void ArrowButton_Click(object sender, EventArgs e)
        {
            ListOfPanels[CurrentPanel].Enabled = false;
            string hintsForUser = GameLogicVar.CheckIfBullsEye() + GameLogicVar.CheckIfHit();
            if(hintsForUser == "BBBB")
            {
                RevealCompGuess();
                foreach (Panel panel in ListOfPanels)
                {
                    panel.Enabled = false;
                }

                return;
            }

            string hint;
            if (hintsForUser != null)
            {
                foreach (Control control in ListOfPanels[CurrentPanel].Controls)
                {
                    if (hintsForUser.Length > 0)
                    {
                        if (control.Name.ToString().Substring(0, 1) == "H")
                        {
                            hint = hintsForUser.Substring(0, 1);
                            hintsForUser = hintsForUser.Substring(1, hintsForUser.Length - 1);
                            if (hint == "B")
                            {
                                control.BackColor = Color.Black;
                            }
                            else if (hint == "Y")
                            {
                                control.BackColor = Color.Yellow;
                            }
                        }
                    }
                }
            }

            GameLogicVar.InitiallizeArray();
            if (NumberOfGuesses != CurrentPanel + 1)
            {
                ListOfPanels[++CurrentPanel].Enabled = true;
            }
            else
            {
                RevealCompGuess();
                MessageBox.Show("GAME OVER! You lost");
            }
        }

        private void ResetStatsToDefault()
        {
            UserChoiceButtonX = 4;
            UserChoiceButtonY = 10;
            ArrowButtonX = 275;
            ArrowButtonY = 30;
            HintsButtonX = 355;
            HintsButtonY = 15;
        }
    }
}