namespace FactoryPattern.FactoryMethod.Pizzas
{
    public class NyStyleClamPizza : Pizzas.Pizza
    {
        public NyStyleClamPizza()
        {
            Name = "Clam pizza";
            Dough = "Dough clam pizza";
            Sauce = "Sauce clam pizza";
            Toppings.Add("Topping clam pizza");
        }
    }
}