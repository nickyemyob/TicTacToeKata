using System.Collections.Generic;

namespace TicTakToeKata
{
    public class Renderer
    {

        public static string Render(List<string> board)
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