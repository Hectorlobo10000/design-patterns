using System.Collections.Generic;
using FactoryPattern.FactoryMethodPattern.Ingredients;
using FactoryPattern.FactoryMethodPattern.Pizzas;

namespace FactoryPattern.FactoryMethodPattern.Stores
{
    public class NyPizzaStore : PizzaStore
    {
        private IDictionary<string, Pizzas.Pizza> _pizzas;

        public NyPizzaStore(IDictionary<string, Pizza> pizzas)
        {
            _pizzas = pizzas;
        }

        public NyPizzaStore()
        {
            
        }

        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NyPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
            }

            return pizza;
        }
    }
}