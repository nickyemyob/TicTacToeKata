using System.Collections.Generic;
using TicTakToeKata.Interfaces;

namespace TicTakToeKata.Players
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