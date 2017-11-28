using System.Collections.Generic;

namespace TicTakToeKata.Players
{
    internal class Solver
    {
        public int Solve(List<string> board)
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