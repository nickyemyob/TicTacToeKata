using System;
using System.Collections.Generic;

namespace TicTakToeKata.Game
{
    internal class Game
    {
        public List<string> NewBoard()
        {
            var board = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            return board;

        }

        public bool Input(string userInput)
        {
            return int.TryParse(userInput, out var _) &&
                   (Convert.ToInt32(userInput) < 9 && Convert.ToInt32(userInput) > -1);
        }

        public bool IsFinished(List<string> board)
        {
            foreach (var token in board)
            {
                if (string.IsNullOrWhiteSpace(token))
                {
                    return false;
                }
            }
            return true;
        }
    }
}