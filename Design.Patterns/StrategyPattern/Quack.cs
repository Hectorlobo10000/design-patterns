using System;

namespace StrategyPattern
{
    public class Quack : IQuackBehavior
    {
        public void QuackM()
        {
            Console.WriteLine("Quack");
        }
    }
}