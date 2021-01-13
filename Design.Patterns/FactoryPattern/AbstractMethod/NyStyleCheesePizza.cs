namespace FactoryPattern.AbstractMethod
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            Name = "NY style cheese pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara sauce";

            Toppings.Add("Grated reggiano cheese");
        }
    }
}