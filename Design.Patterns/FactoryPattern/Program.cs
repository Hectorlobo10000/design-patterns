using System;
using FactoryPattern.AbstractMethod;
using FactoryPattern.FactoryMethodPattern.Stores;
using FactoryPattern.SimplePizzaFactory;
using PizzaStore = FactoryPattern.SimplePizzaFactory.PizzaStore;

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


            Console.WriteLine();


            /*
             * Abstract Method
             */
            var setupNyStylePizzaStore = new SetupNyStylePizzaStore();
            var nyPizzaStore = setupNyStylePizzaStore.GetPizzaStore();
            var nyPizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"I'm ordered {nyPizza.GetName()}");

            Console.WriteLine();

            var setupChicagoStylePizzaStore = new SetupChicagoStylePizzaStore();
            var chicagoPizzaStore = setupChicagoStylePizzaStore.GetPizzaStore();
            var chicagoPizza = chicagoPizzaStore.OrderPizza("clam");
            Console.WriteLine($"I'm ordered {chicagoPizza.GetName()}");

            Console.WriteLine();

            /*
             * Ingredients Factory method pattern
             */

            FactoryMethodPattern.Stores.PizzaStore nyStore = new FactoryMethodPattern.Stores.NyPizzaStore();
            var pizzaafp = nyStore.OrderPizza("cheese");

            Console.ReadKey();
        }
    }
}
