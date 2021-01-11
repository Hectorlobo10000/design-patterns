using System.Collections.Generic;

namespace FactoryPattern.AbstractMethod
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        private IDictionary<string, Pizza> _pizzas;

        public ChicagoStylePizzaStore(IDictionary<string, Pizza> pizzas)
        {
            _pizzas = pizzas;
        }

        protected override Pizza CreatePizza(string type)
        {
            return _pizzas[type];
        }
    }
}