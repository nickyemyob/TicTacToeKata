using System;
using TicTakToeKata.Rules;

namespace TicTakToeKata.Validators
{
    internal class PlayerInputValidator
    {
        private readonly int _boardArea;

        public PlayerInputValidator()
        {
            _boardArea = (int) BoardConfig.Area;
        }

        public bool IsWithinBoardBoundry(int position)
        {
            return position >= 0 && position < _boardArea;
        }

        public bool IsValidInGameInput(string input)
        {
            return int.TryParse(input, out var answer) && IsWithinBoardBoundry(answer);
        }

        public int GetValidInput()
        {
            var inputReader = new InputReader();

            var input = inputReader.UserInput();

            while (!IsValidInGameInput(input))
            {
                Console.WriteLine("Sorry invalid input.");
                input = inputReader.UserInput();
            }

            return int.Parse(input);
        }
    }
}