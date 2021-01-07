namespace FactoryPattern.FactoryMethod.Pizzas
{
    public class ChicagoStylePepperoniPizza : Pizzas.Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = "Pepperoni pizza";
            Dough = "Dough pepperoni pizza";
            Sauce = "Sauce pepperoni pizza";
            Toppings.Add("Topping pepperonie pizza");
        }
    }
}