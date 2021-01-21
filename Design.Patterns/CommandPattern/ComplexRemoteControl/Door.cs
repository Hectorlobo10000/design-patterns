using System;

namespace CommandPattern.ComplexRemoteControl
{
    public class Door : IDoor
    {
        private string _slot;

        public Door(string slot)
        {
            _slot = slot;
        }

        public void Open()
        {
            Console.WriteLine($"{_slot} door is open.");
        }

        public void Close()
        {
            Console.WriteLine($"{_slot} door is close.");
        }
    }
}