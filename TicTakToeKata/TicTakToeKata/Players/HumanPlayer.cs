using System.Collections.Generic;
using TicTakToeKata.Interfaces;

namespace TicTakToeKata.Players
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