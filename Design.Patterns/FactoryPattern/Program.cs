using System;
using FactoryPattern.FactoryMethod.Stores;
using FactoryPattern.SimpleFactory;
using PizzaStore = FactoryPattern.SimpleFactory.PizzaStore;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Simple factory*/
            SimpleFactory.SimpleFactory factory = new SimpleFactory.SimpleFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);

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
