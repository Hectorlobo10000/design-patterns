namespace DecoratorPattern
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}