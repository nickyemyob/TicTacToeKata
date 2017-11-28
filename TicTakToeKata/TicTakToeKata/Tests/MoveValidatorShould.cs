using System.Collections.Generic;
using NUnit.Framework;
using TicTakToeKata.Validators;

namespace TicTakToeKata.Tests
{
    [TestFixture]
    public class MoveValidatorShould
    {
        [Test]
        public void ReturnTrueIfTheCurrentMoveHasAlreadyBeenPlayed()
        {
            

            var board = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var validator = new MoveValidator();

            bool actualValidatorResult = validator.IsValidMove(board, 0);

            Assert.True(actualValidatorResult);

        }

        [Test]
        public void ReturnFalseIfTheCurrentMoveHasNotAlreadyBeenPlayed()
        {
            var board = new List<string>
            {
                "x", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var validator = new MoveValidator();

            bool actualValidatorResult = validator.IsValidMove(board, 0);

            Assert.False(actualValidatorResult);

        }
    }
}