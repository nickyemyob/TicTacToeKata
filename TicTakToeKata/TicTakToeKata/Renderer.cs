using System.Collections.Generic;

namespace TicTakToeKata
{
    internal class Renderer
    {
        public string Render(List<string> board)
        {
            string boardVisualisation = "";
            var count = 0;

            foreach (var token in board)
            {
                if (count > 2)
                {
                    boardVisualisation = boardVisualisation + "\n";
                    count = 0;
                }

                boardVisualisation = boardVisualisation + "[" + token + "]";

                count++;
            }


            return boardVisualisation;
        }
    }
}