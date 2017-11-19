using System.Collections.Generic;

namespace TicTakToeKata
{
    internal class Solver
    {
        public int MakeAMove(List<string> board)
        {
            var movePosition = 0;
            foreach (var token in board)
            {
                if (string.IsNullOrWhiteSpace(token))
                {
                    break;
                }

                movePosition++;
            }

            return movePosition;
        }
    }
}