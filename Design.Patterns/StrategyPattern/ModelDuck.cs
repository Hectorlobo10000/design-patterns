
using System;

namespace StrategyPattern
{
    public  class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm model duck");
        }
    }
}