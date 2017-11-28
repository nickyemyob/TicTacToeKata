﻿using System.Collections.Generic;

namespace TicTakToeKata.Validators
{
    public class MoveValidator
    {
        public bool IsValidMove(List<string> board, int move)
        {
            return string.IsNullOrWhiteSpace(board[move]);
        }
    }
}