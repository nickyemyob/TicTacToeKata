using System;

namespace TicTakToeKata
{
    class Program
    {
        static void Main()
        {
            var game = new Game.Game();
            var board = game.NewBoard();

            var renderer = new Renderer.Renderer();
            Console.WriteLine(renderer.Render(board));

            Console.WriteLine("To make a move, please enter a number from 0-8");

            var userInput = Console.ReadLine();

            while (!Game.Game.Input(userInput))
            {
                Console.WriteLine("Sorry invalid input, please enter a number from 0-8");
                userInput = Console.ReadLine();

            }

            var userMove = Convert.ToInt32(userInput);

            Solver.Solver.UsersMove(board, userMove);

            Console.WriteLine("player (o) at " + userInput);

            Solver.Solver.AIsMove(board);

            Console.WriteLine("Computer (x) moves at ");

            Console.WriteLine(renderer.Render(board));

            Console.ReadLine();


        }
    }
}
