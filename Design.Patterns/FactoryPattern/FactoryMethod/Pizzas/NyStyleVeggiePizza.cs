namespace FactoryPattern.FactoryMethod.Pizzas
{
    public class NyStyleVeggiePizza : Pizzas.Pizza
    {
        public NyStyleVeggiePizza()
        {
            Name = "Veggie Pizza";
            Dough = "Dough Veggie pizza";
            Sauce = "Sauce Veggie pizza";
            Toppings.Add("Topping veggie pizza");
        }
    }
}