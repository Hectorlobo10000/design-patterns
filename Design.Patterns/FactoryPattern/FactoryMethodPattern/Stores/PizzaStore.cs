using System;
using System.Text;
using FactoryPattern.FactoryMethodPattern.Pizzas;

namespace FactoryPattern.FactoryMethodPattern.Stores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
