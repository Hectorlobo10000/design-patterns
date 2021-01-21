﻿namespace CommandPattern.ComplexRemoteControl
{
    public class LightOffCommand : ICommand
    {
        private ILight _light;

        public LightOffCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}