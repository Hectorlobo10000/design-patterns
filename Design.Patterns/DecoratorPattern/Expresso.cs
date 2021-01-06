namespace DecoratorPattern
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}