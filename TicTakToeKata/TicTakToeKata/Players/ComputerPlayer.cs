using System.Collections.Generic;
using TicTakToeKata.Interfaces;

namespace TicTakToeKata.Players
{
    internal class ComputerPlayer : IPlayer
    {

        public string Token { get; }

        public ComputerPlayer(string token)
        {
            Token = token;

        }
        public int Move(List<string> board)
        {
            var position = Solve(board);
            board[position] = Token;
            return position;
        }

        public int Solve(List<string> board)
        {
            var movePosition = 0;
            foreach (var token in board)
            {
                if (string.IsNullOrWhiteSpace(token))
                {
                    break;
                }

                movePosition++;
            }

            return movePosition;
        }
    }
}