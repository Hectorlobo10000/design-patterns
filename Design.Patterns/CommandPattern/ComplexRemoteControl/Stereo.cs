using System;

namespace CommandPattern.ComplexRemoteControl
{
    public class Stereo : IStereo
    {
        private string _slot;

        public Stereo(string slot)
        {
            _slot = slot;
        }

        public void On()
        {
            Console.WriteLine($"{_slot} stereo is on.");
        }

        public void SetCD()
        {
            Console.WriteLine($"{_slot} stereo insert CD.");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"{_slot} stereo volumen is {value}.");
        }

        public void Off()
        {
            Console.WriteLine($"{_slot} stereo is off.");
        }
    }
}