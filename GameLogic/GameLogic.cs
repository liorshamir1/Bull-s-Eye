using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic
{
    public class GameLogic
    {
        private readonly List<int> r_ListNumbers = new List<int>();
        private readonly Random r_Random = new Random();
        private eColors[] m_ComputerGuess = new eColors[4];
        private eColors[] m_UserGuess = new eColors[4];

        public GameLogic()
        {
            GenerateComputerGuess();
            InitiallizeArray();
        }

        public eColors[] ComputerGuess { get => m_ComputerGuess; set => m_ComputerGuess = value; }

        public eColors[] UserGuess
        {
            get
            {
                return this.m_UserGuess;
            }

            set
            {
                this.m_UserGuess = value;
            }
        }

        public void GenerateComputerGuess()
        {
            int number;

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    number = r_Random.Next(1, 8);
                }
                while (r_ListNumbers.Contains(number));
                r_ListNumbers.Add(number);
                ComputerGuess[i] = (eColors)number;
            }
        }

        public void InitiallizeArray()
        {
            for (int i = 0; i < UserGuess.Length; i++)
            {
                UserGuess[i] = eColors.None;
            }
        }

        public bool CheckIfExistsInArray(eColors[] i_UserInput, eColors i_ColorToCheck, int i_Index)
        {
            bool flag = true;

            for (int i = 0; i < i_UserInput.Length; i++)
            {
                if (i_ColorToCheck == i_UserInput[i] && i_Index != i && i_ColorToCheck != eColors.None)
                {
                    flag = false;
                }
            }

            return flag;
        }

        public bool CheckIfTheArrayIsFull()
        {
            bool flag = true;

            foreach (eColors color in UserGuess)
            {
                if (color == eColors.None)
                {
                    flag = false;
                }
            }

            return flag;
        }

        public string CheckIfHit()
        {
            string finalString = string.Empty;

            for (int i = 0; i < UserGuess.Length; i++)
            {
                for (int j = 0; j < ComputerGuess.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (ComputerGuess[j] == UserGuess[i])
                        {
                            finalString += "Y";
                        }
                    }
                }
            }

            return finalString;
        }

        public string CheckIfBullsEye()
        {
            string finalString = string.Empty;

            for (int i = 0; i < ComputerGuess.Length; i++)
            {
                if (ComputerGuess[i] == UserGuess[i])
                {
                    finalString += "B";
                }
            }

            return finalString;
        }
    }
}
