using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Solver
{
    [TestFixture]
    public class SolverShould
    {
        [Test]
        public void AiDeterminesAValidMove()
        {
            var board = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var result = Solver.AiSolver(board);

            Assert.AreEqual(1, result);

        }

        [Test]
        public void UserMakesAValidMove()
        {
            var board = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var expectedBoard = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var usersMove = 0;

            Solver.UsersMove(board, usersMove);

            Assert.AreEqual(expectedBoard, board);
        }

        [Test]
        public void AiMakesAValidMove()
        {
            var board = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var expectedBoard = new List<string>
            {
                "o", "x", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            Solver.AIsMove(board);

            Assert.AreEqual(expectedBoard, board);
        }
    }
}