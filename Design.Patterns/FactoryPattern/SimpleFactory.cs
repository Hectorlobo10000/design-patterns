namespace FactoryPattern
{
    public class SimpleFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if(type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }

            return pizza;
        }
    }
}