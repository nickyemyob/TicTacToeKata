﻿using System.Collections.Generic;

namespace TicTakToeKata
{
    internal class ComputerPlayer : IPlayer
    {

        public int Move(List<string> board, int position)
        {
            board[position] = "x";
            return position;
        }
    }
}