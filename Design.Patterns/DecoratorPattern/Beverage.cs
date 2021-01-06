using System;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string Description = "Unknow Beverage";

        public abstract string GetDescription();

        public abstract Double Cost();
    }
}