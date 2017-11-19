using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata
{
    [TestFixture]
    public class SolverShould
    {
        public void AIDeterminesAValidMove()
        {
            var board = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var result = Solver.solver(board);

            Assert.AreEqual(1, result);

        }

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

        public void AIMakesAValidMove()
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

            var AIMove = 0;

            Solver.AIsMove(board);

            Assert.AreEqual(expectedBoard, board);
        }
    }
}