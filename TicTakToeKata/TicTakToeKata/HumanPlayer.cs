using System.Collections.Generic;

namespace TicTakToeKata
{
    public class HumanPlayer : IPlayer
    {
        public int Move(List<string> board, int position)
        {
            board[position] = "o";
            return position;
        }
    }
}