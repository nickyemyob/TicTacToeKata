using System.Collections.Generic;
using System.Linq;

namespace TicTakToeKata.Rules
{
    public class WinChecker
    {
        private readonly int _gridHeight;
        private readonly int _gridWidth;
        private readonly int _gridArea;

        public WinChecker()
        {
            _gridHeight = (int) BoardConfig.Height;
            _gridWidth = (int) BoardConfig.Width;
            _gridArea = (int) BoardConfig.Area;
        }

        public bool CheckWinCondition(List<string> board)
        {
            return CheckHorizontalWinCondition(board) || CheckVerticalWinCondition(board) || CheckDownwardDiagonalWinCondition(board) || CheckUpwardDiagonalWinCondition(board);
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
            List<string> column = new List<string>();

            var gridHeight = 0;
            var moveToNextVertical = 0;

            for (int i = 0; i < _gridArea; i+=_gridWidth)
            {
                column.Add(board[i]);
                gridHeight++;

                if (gridHeight == _gridHeight)
                {
                    if (!string.IsNullOrWhiteSpace(column[0]) && column.All(x => x == column.First()))
                        return true;
                    column.Clear();
                    gridHeight = 0;
                    moveToNextVertical++;
                    i = moveToNextVertical - _gridWidth;
                }
                
            }
            return false;
        }

        private bool CheckDownwardDiagonalWinCondition(List<string> board)
        {
            List<string> diagonalTokens = new List<string>();

            var counter = 0;

            for (int i = 0; i <= _gridArea; i += _gridWidth + 1)
            {
                diagonalTokens.Add(board[i]);
                counter++;

                if (counter == _gridHeight)
                {
                    if (!string.IsNullOrWhiteSpace(diagonalTokens[0]) && diagonalTokens.All(x => x == diagonalTokens.First()))
                        return true;
                    diagonalTokens.Clear();
                    counter = 0;
                }

            }
            return false;
        }

        private bool CheckUpwardDiagonalWinCondition(List<string> board)
        {
            List<string> diagonalTokens = new List<string>();

            var counter = 0;

            for (int i = _gridWidth - 1; i <= _gridArea; i += _gridWidth - 1)
            {
                diagonalTokens.Add(board[i]);
                counter++;

                if (counter == _gridHeight)
                {
                    if (!string.IsNullOrWhiteSpace(diagonalTokens[0]) && diagonalTokens.All(x => x == diagonalTokens.First()))
                        return true;
                    diagonalTokens.Clear();
                    counter = 0;
                }

            }
            return false;
        }
    }
}