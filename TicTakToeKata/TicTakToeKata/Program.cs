using System;
using System.Collections.Generic;

namespace TicTakToeKata
{
    class Program
    {
        static void Main()
        {
            var game = new Game();
            var board = game.NewBoard();

            var renderer = new Renderer();
            Console.WriteLine(renderer.Render(board));

            Console.ReadLine();
        }
    }
}
