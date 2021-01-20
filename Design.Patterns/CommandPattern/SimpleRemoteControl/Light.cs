using System;

namespace CommandPattern.SimpleRemoteControl
{
    public class Light : ILight
    {
        public void On()
        {
            Console.WriteLine("Light is On");
        }
    }
}