namespace CommandPattern.ComplexRemoteControl
{
    public class LightOnCommand : ICommand
    {
        private ILight _light;

        public LightOnCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}