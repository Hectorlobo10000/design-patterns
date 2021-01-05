
using System;

namespace StrategyPattern
{
    public class MuteQuack : IQuackBehavior
    {
        public void QuackM()
        {
            Console.WriteLine("do nothing");
        }
    }
}