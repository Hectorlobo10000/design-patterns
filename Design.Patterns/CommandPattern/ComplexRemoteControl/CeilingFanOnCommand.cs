namespace CommandPattern.ComplexRemoteControl
{
    public class CeilingFanOnCommand : ICommand
    {
        private IFan _fan;

        public CeilingFanOnCommand(IFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.On();
        }

        public void Undo()
        {
            _fan.Off();
        }
    }
}