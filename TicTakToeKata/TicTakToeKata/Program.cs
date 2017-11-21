using System;

namespace TicTakToeKata
{
    class Program
    {
        static void Main()
        {
            var game = new Game();
            var board = game.NewBoard();

            Console.WriteLine(Renderer.Render(board));

            Console.WriteLine("To make a move, please enter a number from 0-8");

            var userInput = Console.ReadLine();

            while (!game.Input(userInput))
            {
                Console.WriteLine("Sorry invalid input, please enter a number from 0-8");
                userInput = Console.ReadLine();

            }

            var userMove = Convert.ToInt32(userInput);

            game.UsersMove(board, userMove);

            Console.WriteLine("player (o) at " + userInput);

            game.AIsMove(board);

            Console.WriteLine("Computer (x) moves at ");

            Console.WriteLine(Renderer.Render(board));

            Console.ReadLine();


        }
    }
}
