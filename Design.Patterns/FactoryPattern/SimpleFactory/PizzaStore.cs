namespace FactoryPattern.SimpleFactory
{
    public class PizzaStore
    {
        private SimpleFactory _factory;
        public PizzaStore(SimpleFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }
    }
}