using System;
using TicTakToeKata.Interfaces;

namespace TicTakToeKata
{
    public class InputReader : IInputReader
    {
        public string UserInput()
        {
            return Console.ReadLine();
        }
    }
}