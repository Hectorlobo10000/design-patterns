namespace FactoryPattern.FactoryMethod.Pizzas
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            Name = "NY Style sauce and cheese pizza";
            Dough = "Thin Crust dough";
            Sauce = "Marianara sauce";

            Toppings.Add("Granted reggiano cheese");
        }
    }
}