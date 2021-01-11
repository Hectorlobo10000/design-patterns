using System;

namespace FactoryPattern.SimplePizzaFactory
{
    public abstract class Pizza
    {
        protected string Name;

        public void Prepare()
        {
            Console.WriteLine("Prepare pizza...");
        }

        public void Bake()
        {
            Console.WriteLine("Bake pizza...");
        }

        public void Cut()
        {
            Console.WriteLine("Cut pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Box pizza...");
        }

        public string GetName()
        {
            return Name;
        }
    }
}