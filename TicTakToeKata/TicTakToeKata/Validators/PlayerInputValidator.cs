using System;

namespace TicTakToeKata.Validators
{
    internal class PlayerInputValidator
    {
        public bool IsWithinBoardBoundry(int position)
        {
            return position >= 0 && position <= 8;

        }
    }
}