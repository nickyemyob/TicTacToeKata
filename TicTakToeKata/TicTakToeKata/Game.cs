using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTakToeKata
{
    internal class Game
    {
        private readonly int _gridHeight;
        private readonly int _gridWidth;
        private int _gridSpaces;

        public Game()
        {
            _gridHeight = 3;
            _gridWidth = 3;

        }

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

        public bool CheckWinCondition(List<string> board)
        {
            return CheckHorizontalWinCondition(board) || CheckVerticalWinCondition(board);
        }

        private bool CheckHorizontalWinCondition(List<string> board)
        {
            List<string> row = new List<string>();

            var counter = 0;

            foreach (var token in board)
            {
                row.Add(token);
                counter++;

                if (counter == _gridWidth)
                {
                    if (!string.IsNullOrWhiteSpace(row[0]) && row.All(x => x == row.First()))
                        return true;
                    row.Clear();
                    counter = 0;
                }
            }
            return false;
        }


        private bool CheckVerticalWinCondition(List<string> board)
        {
            List<string> Column = new List<string>();

            var counter = 0;

            for (int i = 0; i < _gridHeight * _gridWidth; i+=_gridWidth)
            {
                Column.Add(board[i]);
                counter++;

                if (counter == _gridHeight)
                {
                    if (!string.IsNullOrWhiteSpace(Column[0]) && Column.All(x => x == Column.First()))
                        return true;
                    Column.Clear();
                    counter = 0;
                }
                
            }
            return false;
        }
    }
}