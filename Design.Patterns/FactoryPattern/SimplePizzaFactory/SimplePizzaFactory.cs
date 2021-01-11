using System.Collections.Generic;

namespace FactoryPattern.SimplePizzaFactory
{
    public class SimplePizzaFactory
    {
        private IDictionary<string, Pizza> _pizzas;

        public SimplePizzaFactory(IDictionary<string, Pizza> pizzas)
        {
            _pizzas = pizzas;
        }

        public Pizza CreatePizza(string type)
        {
            return _pizzas[type];
        }
    }
}
