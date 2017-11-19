using System;

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

            Console.WriteLine("Please enter a number:");

            var usersMove = Convert.ToInt32(Console.ReadLine());

            Solver.UsersMove(board, usersMove);

            Console.WriteLine("player (o) at " + usersMove);

            Solver.AIsMove(board);

            Console.WriteLine("Computer (x) moves at ");

            Console.WriteLine(renderer.Render(board));

            Console.ReadLine();


        }
    }
}
