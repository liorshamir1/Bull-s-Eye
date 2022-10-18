using System.Windows.Forms;
using GamesLogic;

namespace UI
{
    public class GameUI
    {
        private FormGameSettings m_FormGameSettings = new FormGameSettings();
        private FormGame m_FormGame;

        public GameUI()
        {
            Run();
        }

        public FormGameSettings GameSettings
        {
            get
            {
                return m_FormGameSettings;
            }
        }

        public FormGame FormGame
        {
            get
            {
                return m_FormGame;
            }

            set
            {
                this.m_FormGame = value;
            }
        }

        public void Run()
        {
            if (GameSettings.ShowDialog() == DialogResult.OK)
            {
                StartGame();
            }
        }

        private void StartGame()
        {
            FormGame = new FormGame(GameSettings.NumberOfChances);
        }
    }
}
