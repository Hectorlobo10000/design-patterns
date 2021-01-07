namespace FactoryPattern.SimplePizzaFactory
{
    public class PizzaStore
    {
        private SimplePizzaFactory _pizzaFactory;
        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = _pizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }
    }
}