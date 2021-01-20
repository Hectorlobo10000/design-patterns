using System;

namespace CommandPattern.ComplexRemoteControl
{
    public class Stereo : IStereo
    {
        private string _livingRoom;

        public Stereo(string livingRoom)
        {
            _livingRoom = livingRoom;
        }

        public void On()
        {
            Console.WriteLine($"{_livingRoom} stereo is on.");
        }

        public void SetCD()
        {
            Console.WriteLine($"{_livingRoom} stereo insert CD.");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"{_livingRoom} stereo volumen is {value}.");
        }

        public void Off()
        {
            Console.WriteLine($"{_livingRoom} stereo is off.");
        }
    }
}