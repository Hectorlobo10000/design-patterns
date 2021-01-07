using System.Collections.Generic;
using FactoryPattern.FactoryMethod.Pizzas;

namespace FactoryPattern.FactoryMethod.Stores
{
    public class ChigacoStylePizzaStore : PizzaStore
    {
        private IDictionary<string, Pizzas.Pizza> _dictionary = new Dictionary<string, Pizzas.Pizza>()
        {
            {"cheese", new ChicagoStyleCheesePizza()},
            {"pepperoni", new ChicagoStylePepperoniPizza()},
            {"clam", new ChigacoStyleClamPizza()},
            {"veggie", new ChicagoStyleVeggiePizza()}
        };

        protected override Pizzas.Pizza CreatePizza(string type)
        {
            return _dictionary[type];
        }
    }
}