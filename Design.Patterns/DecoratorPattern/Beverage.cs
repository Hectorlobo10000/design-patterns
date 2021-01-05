using System;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string Description = "Unknow Beverage";

        public string GetDescription()
        {
            return Description;
        }

        public abstract Double cost();
    }
}