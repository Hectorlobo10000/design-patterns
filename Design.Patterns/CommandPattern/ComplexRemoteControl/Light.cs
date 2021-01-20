using System;

namespace CommandPattern.ComplexRemoteControl
{
    public class Light : ILight
    {
        private string _livingRoom;
        public Light(string livingRoom)
        {
            _livingRoom = livingRoom;
        }

        public void On()
        {
            Console.WriteLine($"{_livingRoom} Light is on.");
        }

        public void Off()
        {
            Console.WriteLine($"{_livingRoom} Light is off.");
        }
    }
}