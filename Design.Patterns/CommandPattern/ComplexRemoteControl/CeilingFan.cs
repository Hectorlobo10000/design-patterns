using System;

namespace CommandPattern.ComplexRemoteControl
{
    public class CeilingFan : IFan
    {
        private string _slot;

        public CeilingFan(string slot)
        {
            _slot = slot;
        }

        public void On()
        {
            Console.WriteLine($"{_slot} ceiling fan is on.");
        }

        public void Off()
        {
            Console.WriteLine($"{_slot} ceiling fan is off.");
        }
    }
}