using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Tests
{
    [TestFixture]
    public class RendererShould
    {
        [Test]
        public void RenderTheBoardOfCurrentStateToTheConsole()
        {

            var board = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            string expectedBoardVisualisation = "[ ][ ][ ]" + "\n" +
                                                "[ ][ ][ ]" + "\n" +
                                                "[ ][ ][ ]";

            var actualBoardVisualisation = Renderer.Render(board);

            Assert.AreEqual(expectedBoardVisualisation,actualBoardVisualisation);

        }
        
    }
}