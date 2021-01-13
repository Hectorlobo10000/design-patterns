using System;
using System.Collections.Generic;

namespace FactoryPattern.AbstractMethod
{
    public abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Prepare Pizza {Name}");
            Console.WriteLine($"Tossing dough...");
            Console.WriteLine($"Adding sauce...");
            Console.WriteLine($"Adding toppings: ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"  {topping}");
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box pizza");
        }

        public string GetName()
        {
            return Name;
        }

    }
}