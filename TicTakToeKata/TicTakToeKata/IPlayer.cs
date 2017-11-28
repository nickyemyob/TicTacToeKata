using System.Collections.Generic;

namespace TicTakToeKata
{
    internal interface IPlayer
    {
        int Move(List<string> board, int position);
    }
}