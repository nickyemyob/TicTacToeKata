using System.Collections.Generic;

namespace TicTakToeKata
{
    internal class Move
    {
        public void UsersMove(List<string> board, int usersMove)
        {
            board[usersMove] = "o";
        }

    }
}