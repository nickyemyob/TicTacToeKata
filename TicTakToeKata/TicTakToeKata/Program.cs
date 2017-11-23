using System;

namespace TicTakToeKata
{
    class Program
    {
        static void Main()
        {
            var game = new Game();
            var board = game.NewBoard();
            var checker = new Checker(3,3);

            while (checker.CheckWinCondition(board) || !game.IsFinished(board))
            {
                Console.WriteLine(Renderer.Render(board));

                Console.WriteLine("To make a move, please enter a number from 0-8");

                var userInput = Console.ReadLine();

                while (!game.IsValidInput(userInput))
                {
                    Console.WriteLine("Sorry invalid input, please enter a number from 0-8");
                    userInput = Console.ReadLine();

                }

                var userMove = Convert.ToInt32(userInput);

                game.UsersMove(board, userMove);

                Console.WriteLine("player (o) at " + userInput);

                int computerMove = game.ComputerPlayersMove(board);

                Console.WriteLine("Computer (x) moves at " + computerMove);

            }

            Console.ReadLine();
            
        }
    }
}
