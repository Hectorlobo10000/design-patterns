namespace CommandPattern.SimpleRemoteControl
{
    public class RemoteControl
    {
        private ICommand _command;

        public RemoteControl()
        {
            
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ButtonWasPressed()
        {
            _command.Execute();
        }
    }
}