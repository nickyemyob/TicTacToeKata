using System;
using System.Collections.Generic;
using TicTakToeKata.GUI;
using TicTakToeKata.Players;
using TicTakToeKata.Rules;
using TicTakToeKata.Validators;

namespace TicTakToeKata
{
    class Program
    {
        static void Main()
        {
            var isNewGame = true;

            while (isNewGame)
            {
                var game = new GameSetup();
                var checker = new WinChecker();
                var computerPlayer = new ComputerPlayer("x");
                var humanPlayer = new HumanPlayer("o");
                var moveValidator = new PlayerMoveValidator();
                //var solver = new Solver();
                var renderer = new Renderer();
                

                var board = game.NewBoard();

                while (!game.IsFinished(board))
                {
                    if (checker.CheckWinCondition(board) || game.IsFinished(board))
                    {
                        Console.WriteLine(renderer.Render(board));
                        break;
                    }

                    //var solve = solver.Solve(board);
                    var computerMove = computerPlayer.Move(board);

                    Console.WriteLine("Computer (x) moves at " + computerMove);

                    if (checker.CheckWinCondition(board) || game.IsFinished(board))
                    {
                        Console.WriteLine(renderer.Render(board));
                        break;
                    }

                    Console.WriteLine(renderer.Render(board));

                    Console.WriteLine("To make a move, please enter a number from 0-8");

                    var userInput = Console.ReadLine();

                    var validInput = game.IsValidInput(userInput);

                    ValidInputPrompt(game, ref userInput, ref validInput, board, renderer);

                    var userMove = Convert.ToInt32(userInput);

                    while (!moveValidator.IsValidMove(board, userMove))
                    {
                        Console.WriteLine("Sorry invalid move, please choose an empty space");
                        Console.WriteLine(renderer.Render(board));

                        userInput = Console.ReadLine();
                        validInput = game.IsValidInput(userInput);
                        ValidInputPrompt(game, ref userInput, ref validInput, board, renderer);

                        userMove = Convert.ToInt32(userInput);
                    }

                    userMove = Convert.ToInt32(userInput);

                    humanPlayer.Move(board);

                    Console.WriteLine("player (o) at " + userInput);


                }

                if (game.IsFinished(board))
                {
                    Console.WriteLine("Draw!");
                }

                if (checker.CheckWinCondition(board))
                {
                    Console.WriteLine("Winner!");
                }

                Console.WriteLine("Play again? y/n");
                var gamePlayIntent = Console.ReadLine();

                isNewGame = gamePlayIntent == "y";
                
            }

        }

        private static void ValidInputPrompt(GameSetup gameSetup, ref string userInput, ref bool validInput, List<string> board, Renderer renderer)
        {
            while (!validInput)
            {
                Console.WriteLine("Sorry invalid input, please enter a number from 0-8");
                Console.WriteLine(renderer.Render(board));

                userInput = Console.ReadLine();
                validInput = gameSetup.IsValidInput(userInput);
            }
        }
    }
}
