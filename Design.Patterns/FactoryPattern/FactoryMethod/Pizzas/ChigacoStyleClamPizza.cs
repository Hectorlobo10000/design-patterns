namespace FactoryPattern.FactoryMethod.Pizzas
{
    public class ChigacoStyleClamPizza : Pizzas.Pizza
    {
        public ChigacoStyleClamPizza()
        {
            Name = "Clam pizza";
            Dough = "Dough clam pizza";
            Sauce = "Sauce clam pizza";
            Toppings.Add("Topping clam pizza");
        }
    }
}