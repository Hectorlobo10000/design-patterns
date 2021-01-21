namespace CommandPattern.ComplexRemoteControl
{
    public class StereoOffWithCdCommand : ICommand
    {
        private IStereo _stereo;

        public StereoOffWithCdCommand(IStereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}