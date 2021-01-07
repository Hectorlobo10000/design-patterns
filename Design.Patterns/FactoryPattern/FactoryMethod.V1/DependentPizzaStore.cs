using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.FactoryMethod.V1
{
    public class DependentPizzaStore
    {
        public Pizza CreatePizza(string style, string type)
        {
            Pizza pizza = null;

            if (style.Equals("NY"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new NyStyleCheesePizza();
                } else if (type.Equals("veggie"))
                {
                    pizza = new NyStyleVeggiePizza();
                } else if (type.Equals("clam"))
                {
                    pizza = new NyStyleClamPizza();
                } else if (type.Equals("pepperoni"))
                {
                    pizza = new NyStylePepperoniPizza();
                }
            } else if (style.Equals("chicago"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new ChicagoStyleCheesePizza();
                } else if (type.Equals("veggie"))
                {
                    pizza = new ChicagoStyleVeggiePizza();
                } else if (type.Equals("clam"))
                {
                    pizza = new ChicagoStyleClamPizza();
                } else if (type.Equals("pepperoni"))
                {
                    pizza = new ChicagoStylePepperoniPizza();
                }
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();


            return pizza;

        }
    }
}
