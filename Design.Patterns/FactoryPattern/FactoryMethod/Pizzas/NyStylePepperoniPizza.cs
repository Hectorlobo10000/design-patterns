namespace FactoryPattern.FactoryMethod.Pizzas
{
    public class NyStylePepperoniPizza : Pizzas.Pizza
    {
        public NyStylePepperoniPizza()
        {
            Name = "Pepperoni pizza";
            Dough = "Dough pepperoni pizza";
            Sauce = "Sauce pepperoni pizza";
            Toppings.Add("Topping pepperoni pizza");
        }
    }
}