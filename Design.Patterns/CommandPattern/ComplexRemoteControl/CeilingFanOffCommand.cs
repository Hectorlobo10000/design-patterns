namespace CommandPattern.ComplexRemoteControl
{
    public class CeilingFanOffCommand : ICommand
    {
        private IFan _fan;

        public CeilingFanOffCommand(IFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.Off();
        }

        public void Undo()
        {
            _fan.On();
        }
    }
}