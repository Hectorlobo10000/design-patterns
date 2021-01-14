using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.FactoryMethodPattern.Ingredients;

namespace FactoryPattern.FactoryMethodPattern.Pizzas
{
    public abstract class Pizza
    {
        protected string Name;
        protected ISauce Sauce;
        protected ICheese Cheese;

        protected abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official pizzaStore box");
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
