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
            } else if (type.Equals("pepperoni"))
            {
                pizza = new Pepperoni();
            } else if (type.Equals(("clam")))
            {
                pizza = new ClamPizza();
            } else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }

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

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;

        }
    }
}