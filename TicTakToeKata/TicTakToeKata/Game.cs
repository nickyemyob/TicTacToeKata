using System.Collections.Generic;

namespace TicTakToeKata
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

        public static bool Input(string userInput)
        {
            return int.TryParse(userInput, out var _);
        }
    }
}