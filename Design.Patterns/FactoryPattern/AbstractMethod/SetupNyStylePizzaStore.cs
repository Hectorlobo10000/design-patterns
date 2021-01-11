using System.Collections.Generic;

namespace FactoryPattern.AbstractMethod
{
    public class SetupNyStylePizzaStore : ISetupPizzaStore
    {
        public PizzaStore GetPizzaStore()
        {
            return new NyStylePizzaStore(new Dictionary<string, Pizza>()
            {
                {"cheese",  new NyStyleCheesePizza()},
                {"pepperoni", new NyStylePepperoniPizza()},
                {"clam", new NyStyleClamPizza()},
                {"veggie", new NyStyleVeggiePizza()}
            });
        }
    }
}