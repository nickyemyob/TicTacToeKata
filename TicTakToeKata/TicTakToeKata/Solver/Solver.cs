using System.Collections.Generic;

namespace TicTakToeKata.Solver
{
    internal class Solver
    {
        public static int AiSolver(List<string> board)
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