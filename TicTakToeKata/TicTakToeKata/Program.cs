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

            var UsersMove = Console.ReadLine();



            Console.WriteLine("player (o) at " + UsersMove);

            var computer = new Solver();
            var computerMove = computer.MakeAMove(board);

            Console.WriteLine("Computer (x) moves at " + computerMove);

            Console.WriteLine(renderer.Render(board));

            Console.ReadLine();


        }
    }
}
