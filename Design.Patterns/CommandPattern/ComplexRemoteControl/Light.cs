using System;

namespace CommandPattern.ComplexRemoteControl
{
    public class Light : ILight
    {
        private string _slot;
        public Light(string slot)
        {
            _slot = slot;
        }

        public void On()
        {
            Console.WriteLine($"{_slot} Light is on.");
        }

        public void Off()
        {
            Console.WriteLine($"{_slot} Light is off.");
        }
    }
}