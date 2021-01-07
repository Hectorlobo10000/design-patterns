using System;

namespace FactoryPattern.FactoryMethod.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizzas.Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago style deep dish cheese pizza";
            Dough = "Extra thick crust dough";
            Sauce = "Plum tomato sauce";

            Toppings.Add("Shredded mozzarella cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}