using System;
using CommandPattern.ComplexRemoteControl;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The command pattern: encapsulates a request as an object, thereby letting you parameterize other objects with different request, queue or log requests, and support undoable operations
             */

            /*
             * Simple Test
             */
             //RemoteControl remote = new RemoteControl();
             //ILight light = new Light();
             //LightOnCommand lightOn = new LightOnCommand(light);

             //remote.SetCommand(lightOn);
             //remote.ButtonWasPressed();


            /*
            * Remote control
            */
            /*RemoteControl remoteControl = new RemoteControl();

            ILight livingRoomLight = new Light("Living Room");

            ILight kitchenLight = new Light("Kitchen");

            IStereo stereo = new Stereo("Living Room");

            LightOnCommand lightOnCommand = new LightOnCommand(livingRoomLight);
            LightOffCommand lightOffCommand = new LightOffCommand(livingRoomLight);

            LightOnCommand kitcheLightOnCommand = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenOffCommand = new LightOffCommand(kitchenLight);

            StereoOnWithCdCommand stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
            StereoOffWithCdCommand stereoOffWithCdCommand = new StereoOffWithCdCommand(stereo);

            remoteControl.SetCommand(0, lightOnCommand, lightOffCommand);
            remoteControl.SetCommand(1, kitcheLightOnCommand, kitchenOffCommand);
            remoteControl.SetCommand(2, stereoOnWithCdCommand, stereoOffWithCdCommand);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);*/
            
            /*
             * Remote control with undo
             */
            
            RemoteControl remoteControl = new RemoteControl();
            
            ILight livingRoomLight = new Light("Living room");
            
            LightOnCommand lightOnCommand = new LightOnCommand(livingRoomLight);
            LightOffCommand lightOffCommand = new LightOffCommand(livingRoomLight);
            
            remoteControl.SetCommand(0, lightOnCommand, lightOffCommand);
            
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            
            remoteControl.UndoButtonWasPushed();
            

            Console.ReadKey();
        }
    }
}
