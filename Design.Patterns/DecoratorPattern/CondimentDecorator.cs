
using System;

namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
        public abstract override Double Cost();
    }
}