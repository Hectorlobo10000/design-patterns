using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.FactoryMethodPattern.Ingredients;

namespace FactoryPattern.FactoryMethodPattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
            Name = "NY style cheese pizza";
        }

        protected override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Sauce = _pizzaIngredientFactory.CreateSauce();
        }
    }
}
