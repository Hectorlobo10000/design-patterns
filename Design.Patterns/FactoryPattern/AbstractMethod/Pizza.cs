using System;

namespace FactoryPattern.AbstractMethod
{
    public abstract class Pizza
    {
        protected string Name;

        public void Prepare()
        {
            Console.WriteLine("Prepare Pizza");
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