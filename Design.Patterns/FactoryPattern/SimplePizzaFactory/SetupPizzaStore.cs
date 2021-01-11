using System.Collections.Generic;

namespace FactoryPattern.SimplePizzaFactory
{
    public class SetupPizzaStore
    {
        public static SimplePizzaFactory GetFactory()
        {
            return new SimplePizzaFactory(new Dictionary<string, Pizza>()
            {
                {"cheese", new CheesePizza()},
                {"pepperoni", new PepperoniPizza()},
                {"clam", new ClamPizza()},
                {"veggie", new VeggiePizza()},
            });
        }
    }
}