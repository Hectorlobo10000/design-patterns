using System.Collections.Generic;

namespace FactoryPattern.FactoryMethod.V1
{
    public class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggie> CreateVeggieses()
        {
            return new List<Veggie>()
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperonie();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }
    }
}