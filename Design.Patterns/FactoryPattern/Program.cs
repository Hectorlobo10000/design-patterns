using System;
using FactoryPattern.FactoryMethod.Stores;
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
            /*Simple pizzaFactory*/
            SimplePizzaFactory.SimplePizzaFactory pizzaFactory = new SimplePizzaFactory.SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(pizzaFactory);

            Pizza simplePizza = pizzaStore.OrderPizza("veggie");
            Console.WriteLine($"I ordered a {simplePizza.GetName()}");
            Console.WriteLine();

            /* Factory method */
            FactoryMethod.Stores.PizzaStore nyStore = new NyStylePizzaStore();
            FactoryMethod.Stores.PizzaStore chicagoStore = new ChigacoStylePizzaStore();

            FactoryMethod.Pizzas.Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}");

            Console.WriteLine();

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}");


            Console.ReadKey();
        }
    }
}
