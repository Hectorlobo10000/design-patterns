namespace CommandPattern.SimpleRemoteControl
{
    public class  LightOnCommand : ICommand
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
    }
}