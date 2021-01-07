using System;

namespace FactoryPattern.FactoryMethod.V1
{
    public class NyStyleCheesePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public NyStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}