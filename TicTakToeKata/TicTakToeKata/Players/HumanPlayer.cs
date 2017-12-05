using System;
using System.Collections.Generic;
using TicTakToeKata.Interfaces;

namespace TicTakToeKata.Players
{
    public class HumanPlayer : IPlayer
    {
        public string Token { get; }

        public HumanPlayer(string token)
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
            var input = Console.ReadLine();

            //put string into validator
            var check = int.TryParse(input, out var answer);
            return answer;
        }
    }
}