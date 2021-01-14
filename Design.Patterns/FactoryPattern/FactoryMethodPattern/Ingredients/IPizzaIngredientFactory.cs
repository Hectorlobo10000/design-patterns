namespace FactoryPattern.FactoryMethodPattern.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        ISauce CreateSauce();
        ICheese CreateCheese();

    }
}