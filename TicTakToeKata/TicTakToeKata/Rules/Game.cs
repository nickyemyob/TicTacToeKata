using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTakToeKata.Rules
{
    public class Game
    {
        private readonly int _gridHeight;
        private readonly int _gridWidth;
        private readonly int _gridArea;


        public Game(int gridHeight, int gridWidth)
        {
            _gridHeight = gridHeight;
            _gridWidth = gridWidth;
            _gridArea = gridHeight * gridWidth;

        }

        public List<string> NewBoard()
        {

            var board = Enumerable.Repeat(" ", _gridArea).ToList();

            return board;

        }

        public bool IsValidInput(string userInput)
        {
            return Int32.TryParse(userInput, out var _) &&
                   (Convert.ToInt32(userInput) < 9 && Convert.ToInt32(userInput) > -1);
        }

        public bool IsFinished(List<string> board)      
        {
            return board.All(token => !String.IsNullOrWhiteSpace(token));
        }
    }
}