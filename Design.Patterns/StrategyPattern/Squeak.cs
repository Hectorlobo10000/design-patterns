
using System;

namespace StrategyPattern
{
    public class Squeak : IQuackBehavior
    {
        public void QuackM()
        {
            Console.WriteLine("Squeak");
        }
    }
}