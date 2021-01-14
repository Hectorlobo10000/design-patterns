
namespace FactoryPattern.FactoryMethodPattern.Ingredients
{
    public class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }
    }
}