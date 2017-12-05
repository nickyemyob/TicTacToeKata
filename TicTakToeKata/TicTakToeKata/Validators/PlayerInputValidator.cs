using System;
using TicTakToeKata.Interfaces;

namespace TicTakToeKata.Validators
{
    internal class PlayerInputValidator
    {
        public bool IsWithinBoardBoundry(int position)
        {
            return position >= 0 && position <= 8;

        }

        public bool GetReleventInGameInput(string input)
        {
            var check = int.TryParse(input, out var answer);
            return check;
        }

    }
}