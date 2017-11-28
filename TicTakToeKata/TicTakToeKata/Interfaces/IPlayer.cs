using System.Collections.Generic;

namespace TicTakToeKata.Interfaces
{
    internal interface IPlayer
    {
        int Move(List<string> board, int position);
    }
}