namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend coffee";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            return .89;
        }
    }
}