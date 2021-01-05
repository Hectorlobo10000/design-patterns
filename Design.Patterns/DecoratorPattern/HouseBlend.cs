namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend coffee";
        }

        public override double cost()
        {
            return .89;
        }
    }
}