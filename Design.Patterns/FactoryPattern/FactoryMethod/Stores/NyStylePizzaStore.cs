using System.Collections.Generic;
using FactoryPattern.FactoryMethod.Pizzas;

namespace FactoryPattern.FactoryMethod.Stores
{
    public class NyStylePizzaStore : PizzaStore
    {
        private IDictionary<string, Pizzas.Pizza> _dictionary = new Dictionary<string, Pizzas.Pizza>()
        {
            {"cheese", new NyStyleCheesePizza()},
            {"pepperoni", new NyStylePepperoniPizza()},
            {"clam", new NyStyleClamPizza()},
            {"veggie", new NyStyleVeggiePizza()}
        };

        protected override Pizzas.Pizza CreatePizza(string type)
        {
            return _dictionary[type];
        }
    }
}