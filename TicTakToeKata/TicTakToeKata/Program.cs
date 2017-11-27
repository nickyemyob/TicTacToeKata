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
            var moves = new Move();
            var moveValidator = new MoveValidator();

            while (checker.CheckWinCondition(board) || !game.IsFinished(board))
            {
                Console.WriteLine(Renderer.Render(board));

                Console.WriteLine("To make a move, please enter a number from 0-8");

                var userInput = Console.ReadLine();

                int userMove;

                var validInput = game.IsValidInput(userInput);

                    while (!validInput)
                    {
                        Console.WriteLine("Sorry invalid input, please enter a number from 0-8");
                        userInput = Console.ReadLine();
                        validInput = game.IsValidInput(userInput);
                    }

                userMove = Convert.ToInt32(userInput);

                while (!moveValidator.IsValidMove(board, userMove))
                {
                    Console.WriteLine("Sorry invalid move, please choose an empty space");

                    userInput = Console.ReadLine();
                    validInput = game.IsValidInput(userInput);
                    ValidInputPrompt(game, ref userInput, ref validInput);

                    userMove = Convert.ToInt32(userInput);

                }

                userMove = Convert.ToInt32(userInput);

                moves.UsersMove(board, userMove);

                Console.WriteLine("player (o) at " + userInput);

                int computerMove = moves.ComputerPlayersMove(board);

                Console.WriteLine("Computer (x) moves at " + computerMove);

            }

            Console.ReadLine();
            
        }

        private static void ValidInputPrompt(Game game, ref string userInput, ref bool validInput)
        {
            while (!validInput)
            {
                Console.WriteLine("Sorry invalid input, please enter a number from 0-8");
                userInput = Console.ReadLine();
                validInput = game.IsValidInput(userInput);
            }
        }
    }
}
