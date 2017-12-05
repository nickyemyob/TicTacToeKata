using System;
using System.Collections.Generic;
using TicTakToeKata.Interfaces;
using TicTakToeKata.Validators;

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
            var playerInputValidator = new PlayerInputValidator();

            var input = playerInputValidator.GetValidInput();

            return input;
        }
    }
}