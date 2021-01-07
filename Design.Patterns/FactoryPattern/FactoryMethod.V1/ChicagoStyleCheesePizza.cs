using System;

namespace FactoryPattern.FactoryMethod.V1
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public ChicagoStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
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