using System;
using System.Collections.Generic;
using System.Linq;

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

        public void UsersMove(List<string> board, int usersMove)
        {
            board[usersMove] = "o";
        }

        public void ComputerPlayersMove(List<string> board)
        {
            var aiMove = ComputerPlayer.Solve(board);
            board[aiMove] = "x";
        }

        public bool Input(string userInput)
        {
            return Int32.TryParse(userInput, out var _) &&
                   (Convert.ToInt32(userInput) < 9 && Convert.ToInt32(userInput) > -1);
        }

        public bool IsFinished(List<string> board)
        {
            return board.All(token => !String.IsNullOrWhiteSpace(token));
        }
    }
}