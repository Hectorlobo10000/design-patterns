using System;
using FactoryPattern.SimplePizzaFactory;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *
             * The Factory Method Pattern: defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory method lets a class defer instantiation to subclasses.
             *
             * Design Principle: Depend upon abstractions. Do not depend upon concrete classes.
             *
             */

            /*
             * Simple Factory
             */
            var factory = SetupPizzaStore.GetFactory();
            var pizzaStore = new PizzaStore(factory);
            var pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine($"I'm ordered {pizza.GetName()}");


            Console.ReadKey();
        }
    }
}
