using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Renderer
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

            var renderer = new Renderer();
            var actualBoardVisualisation = renderer.Render(board);

            Assert.AreEqual(expectedBoardVisualisation,actualBoardVisualisation);

        }
        
    }
}