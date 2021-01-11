using System.Collections.Generic;

namespace FactoryPattern.AbstractMethod
{
    public class SetupChicagoStylePizzaStore : ISetupPizzaStore
    {
        public PizzaStore GetPizzaStore()
        {
            return new ChicagoStylePizzaStore(new Dictionary<string, Pizza>()
            {
                {"cheese", new ChicagoStyleCheesePizza()},
                {"pepperoni", new ChicagoStylePepperoniPizza()},
                {"clam", new ChicagoStyleClamPizza()},
                {"veggie", new ChicagoStyleVeggiePizza()}
            });
        }
    }
}