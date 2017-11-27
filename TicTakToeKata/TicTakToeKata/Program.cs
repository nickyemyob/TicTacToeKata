using System;
using System.Collections.Generic;

namespace TicTakToeKata
{
    class Program
    {
        static void Main()
        {
            var game = new Game();
            var checker = new Checker(3, 3);
            var moves = new Move();
            var moveValidator = new MoveValidator();

            var board = game.NewBoard();

            while (!game.IsFinished(board))
            {
                if (checker.CheckWinCondition(board) || game.IsFinished(board))
                {
                    Console.WriteLine(Renderer.Render(board));
                    break;
                }
                var computerMove = moves.ComputerPlayersMove(board);

                Console.WriteLine("Computer (x) moves at " + computerMove);

                if (checker.CheckWinCondition(board) || game.IsFinished(board))
                {
                    Console.WriteLine(Renderer.Render(board));
                    break;
                }

                Console.WriteLine(Renderer.Render(board));

                Console.WriteLine("To make a move, please enter a number from 0-8");

                var userInput = Console.ReadLine();

                var validInput = game.IsValidInput(userInput);

                ValidInputPrompt(game, ref userInput, ref validInput, board);

                var userMove = Convert.ToInt32(userInput);

                while (!moveValidator.IsValidMove(board, userMove))
                {
                    Console.WriteLine("Sorry invalid move, please choose an empty space");
                    Console.WriteLine(Renderer.Render(board));

                    userInput = Console.ReadLine();
                    validInput = game.IsValidInput(userInput);
                    ValidInputPrompt(game, ref userInput, ref validInput, board);

                    userMove = Convert.ToInt32(userInput);
                }

                userMove = Convert.ToInt32(userInput);

                moves.UsersMove(board, userMove);

                Console.WriteLine("player (o) at " + userInput);

                
            }

            Console.WriteLine("Winner!");
            Console.ReadLine();

        }

        private static void ValidInputPrompt(Game game, ref string userInput, ref bool validInput, List<string> board)
        {
            while (!validInput)
            {
                Console.WriteLine("Sorry invalid input, please enter a number from 0-8");
                Console.WriteLine(Renderer.Render(board));

                userInput = Console.ReadLine();
                validInput = game.IsValidInput(userInput);
            }
        }
    }
}
