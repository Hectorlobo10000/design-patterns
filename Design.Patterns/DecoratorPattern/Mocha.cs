using System;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Mocha";
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }
}