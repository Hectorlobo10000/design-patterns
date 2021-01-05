
using System;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast coffe";
        }

        public override double cost()
        {
            return .99;
        }
    }
}