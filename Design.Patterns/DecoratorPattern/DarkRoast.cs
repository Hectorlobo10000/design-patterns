
using System;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast coffe";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            return .99;
        }
    }
}