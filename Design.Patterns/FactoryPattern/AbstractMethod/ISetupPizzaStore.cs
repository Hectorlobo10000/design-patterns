using System.Collections.Generic;

namespace FactoryPattern.AbstractMethod
{
    public interface ISetupPizzaStore
    {
        PizzaStore GetPizzaStore();
    }
}