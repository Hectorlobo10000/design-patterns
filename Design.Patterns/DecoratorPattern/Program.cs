using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Design principle: Classes should be open for extension, but closed for modification.
             *
             * The Decorator Pattern: attaches additional responsabilities to an object dynamically.
             * Decorators provide a flexible alternative to subclassing for extending functionality.
             */

            Beverage beverage = new Expresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.cost()}");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.cost()}");

            Console.ReadKey();
        }
    }
}
