namespace FactoryPattern.FactoryMethod.Pizzas
{
    public class ChicagoStyleVeggiePizza : Pizzas.Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Veggie pizza";
            Dough = "Dough veggie pizza";
            Sauce = "Sauce veggie pizza";
            Toppings.Add("Topping veggie pizza");
        }
    }
}