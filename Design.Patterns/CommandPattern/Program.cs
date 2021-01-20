using System;
using CommandPattern.SimpleRemoteControl;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Simple Test
             */
             RemoteControl remote = new RemoteControl();
             ILight light = new Light();
             LightOnCommand lightOn = new LightOnCommand(light);

             remote.SetCommand(lightOn);
             remote.ButtonWasPressed();



            Console.ReadKey();
        }
    }
}
