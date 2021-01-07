

using System.Collections.Generic;

namespace FactoryPattern.FactoryMethod.V1
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggie> CreateVeggieses();
        Pepperoni CreatePepperoni();
        Clams CreateClam();

    }
}