namespace CommandPattern.ComplexRemoteControl
{
    public class DoorOpenCommand : ICommand
    {
        private IDoor _door;

        public DoorOpenCommand(IDoor door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Open();
        }

        public void Undo()
        {
            _door.Close();
        }
    }
}