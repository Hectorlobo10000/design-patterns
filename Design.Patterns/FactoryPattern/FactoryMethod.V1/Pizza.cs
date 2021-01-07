using System;
using System.Collections.Generic;

namespace FactoryPattern.FactoryMethod.V1
{
    public abstract class Pizza
    {
        protected string Name;
        protected Dough Dough;
        protected Sauce Sauce;
        protected List<Veggie> Veggies;
        protected Cheese Cheese;
        protected Pepperoni Pepperoni;
        protected Clams Clam;

        public abstract void Prepare();

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
            Console.WriteLine("Place pizza in official pizza store box");
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return "Pizza done";
        }
    }
}