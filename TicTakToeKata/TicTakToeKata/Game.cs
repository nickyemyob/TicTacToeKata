using System;
using System.Collections.Generic;

namespace TicTakToeKata
{
    internal class Game
    {
        public List<string> NewBoard()
        {
            var board = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            return board;

        }

        public bool Input(string userInput)
        {
            return Int32.TryParse(userInput, out var _) &&
                   (Convert.ToInt32(userInput) < 9 && Convert.ToInt32(userInput) > -1);
        }

        public bool IsFinished(List<string> board)
        {
            foreach (var token in board)
            {
                if (String.IsNullOrWhiteSpace(token))
                {
                    return false;
                }
            }
            return true;
        }

        public void UsersMove(List<string> board, int usersMove)
        {
            board[usersMove] = "o";
        }

        public void AIsMove(List<string> board)
        {
            var aiMove = Solver.Solver.AiSolver(board);
            board[aiMove] = "x";
        }
    }
}