using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Design principle: Identify the aspects of your application that vary and separate them from what stays the same.
             *
             *Design principle: Program to an interface, not an implementation.
             *
             *Design principle: Favor composition over inheritance.
             *
             * The Strategy pattern: defines a family of algorithms, encapsulates each one, and makes them interchangeable.
             * Strategy lets the algorithm vary independently from clients that use it.
             */

            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.PerformQuack();
            mallard.PerformFly();


            Duck model = new ModelDuck();
            model.display();
            model.PerformQuack();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.ReadKey();

        }
    }
}
