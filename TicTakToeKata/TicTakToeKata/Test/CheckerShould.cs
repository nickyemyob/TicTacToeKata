using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Test
{
    public class CheckerShould
    {
        private static readonly object[] WinningGameScenarios =
        {
            new object[] {
                new List<string>
                {
                    "x", "x", "x",
                    "o", "o", " ",
                    " ", " ", " "
                } 
            },
            new object[] {
                new List<string>
                {
                    "o", "o", " ",
                    "x", "x", "x",
                    " ", " ", " "
                }
            },
            new object[] {
                new List<string>
                {
                    "o", "o", " ",
                    " ", " ", " ",
                    "x", "x", "x"
                }
            },
            new object[] {
                new List<string>
                {
                    "x", "o", " ",
                    "x", "o", " ",
                    "x", " ", " "
                }
            },
            new object[] {
                new List<string>
                {
                    " ", "x", "o",
                    " ", "x", "o",
                    " ", "x", " "
                }
            },
            new object[] {
                new List<string>
                {
                    "x", "o", "o",
                    " ", "x", " ",
                    " ", " ", "x"
                }
            },
            new object[] {
                new List<string>
                {
                    "o", "o", "x",
                    " ", "x", " ",
                    "x", " ", " "
                }
            }
        };

        [TestCaseSource(nameof(WinningGameScenarios))]
        [Test]
        public void DetermineWinnerIfWinConditionsAreMet(List<string> winningBoard)
        {
            var checker = new Checker(3, 3);
            var isWinner = checker.CheckWinCondition(winningBoard);

            Assert.True(isWinner);

        }

        private static readonly object[] UnfinishedGameScenarios =
        {
            new object[] {
                new List<string>
                {
                    "x", "x", " ",
                    "o", "o", " ",
                    "x", " ", " "
                }
            },
            new object[] {
                new List<string>
                {
                    "o", "o", " ",
                    "x", "x", " ",
                    " ", "x", " "
                }
            },
            new object[] {
                new List<string>
                {
                    "o", "x", " ",
                    "x", "o", "x",
                    "o", "o", " "
                }
            },
            new object[] {
                new List<string>
                {
                    "x", "x", " ",
                    "o", "o", "x",
                    " ", " ", " "
                }
            }
        };

        [TestCaseSource(nameof(UnfinishedGameScenarios))]
        [Test]
        public void NotDetermineWinnerIfWinConditionsAreNotMet(List<string> board)
        {
            var checker = new Checker(3, 3);
            var isWinner = checker.CheckWinCondition(board);

            Assert.False(isWinner);

        }
    }
}