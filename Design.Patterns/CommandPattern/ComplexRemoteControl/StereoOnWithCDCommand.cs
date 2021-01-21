namespace CommandPattern.ComplexRemoteControl
{
    public class  StereoOnWithCdCommand : ICommand
    {
        private IStereo _stereo;

        public StereoOnWithCdCommand(IStereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}