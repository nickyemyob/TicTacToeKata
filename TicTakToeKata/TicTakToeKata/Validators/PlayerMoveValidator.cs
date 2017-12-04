using System.Collections.Generic;

namespace TicTakToeKata.Validators
{
    public class PlayerMoveValidator
    {
        public bool IsValidMove(List<string> board, int move)
        {
            return string.IsNullOrWhiteSpace(board[move]);
        }
    }
}