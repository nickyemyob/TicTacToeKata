using System.Collections.Generic;

namespace TicTakToeKata
{
    internal class Move
    {
        public void UsersMove(List<string> board, int usersMove)
        {
            if (string.IsNullOrWhiteSpace(board[usersMove]))
            {
                board[usersMove] = "o";
            }
        }

        public int ComputerPlayersMove(List<string> board)
        {
            var aiMove = ComputerPlayer.Solve(board);
            board[aiMove] = "x";

            return aiMove;
        }
    }
}