using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata
{
    [TestFixture]
    public class SolverShould
    {
        [Test]
        public void MakeAValidMoveOnTheBoardAfterTheUser()
        {
            var board = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var solver = new Solver();

            var result = solver.MakeAMove(board);

            Assert.AreEqual(1, result);
        }
    }
}