
using System;

namespace FactoryPattern.SimpleFactory
{
    public abstract class Pizza
    {
        protected string Name;

        public  void Prepare()
        {
            Console.WriteLine("Prepare...");
        }

        public void Bake()
        {
            Console.WriteLine("Bake...");
        }
        public  void Cut()
        {
            Console.WriteLine("Cut...");
        }
        public void Box()
        {
            Console.WriteLine("Box...");
        }

        public string GetName()
        {
            return Name;
        }
    }
}