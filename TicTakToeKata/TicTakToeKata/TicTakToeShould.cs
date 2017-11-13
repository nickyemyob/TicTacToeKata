using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata
{
    [TestFixture]
    public class TicTakToeShould
    {
        public void MakeAMoveOnTheBoardAfterTheUser()
        {
            var board = new List<string>();
            board.Add("o");
            board.Add(null);
            board.Add(null);
            board.Add(null);
            board.Add(null);
            board.Add(null);
            board.Add(null);
            board.Add(null);
            board.Add(null);

            var solver = new Solver();

            var result = solver.Solve();

            Assert.AreEqual(2, result);
        }
    }
}