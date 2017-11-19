﻿using System.Collections.Generic;

namespace TicTakToeKata
{
    internal class Solver
    {
        public static int solver(List<string> board)
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

        public static void UsersMove(List<string> board, int usersMove)
        {
            board[usersMove] = "o";
        }

        public static void AIsMove(List<string> board)
        {
            var aiMove = solver(board);
            board[aiMove] = "x";
        }
    }
}