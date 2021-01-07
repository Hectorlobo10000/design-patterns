namespace FactoryPattern.FactoryMethod.Stores
{
    public abstract class PizzaStore
    {
        public Pizzas.Pizza OrderPizza(string type)
        {
            Pizzas.Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizzas.Pizza CreatePizza(string type);
    }
}