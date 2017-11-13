using System;
using System.Collections.Generic;

namespace TicTakToeKata
{
    class Program
    {
        static void Main()
        {
            var board = new List<string>();
            board.Add("o");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");

            var renderer = new Renderer();
            Console.WriteLine(renderer.Render(board));

            Console.ReadLine();
        }
    }
}
