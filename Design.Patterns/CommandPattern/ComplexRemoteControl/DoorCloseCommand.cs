namespace CommandPattern.ComplexRemoteControl
{
    public class DoorCloseCommand : ICommand
    {
        private IDoor _door;

        public DoorCloseCommand(IDoor door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Close();
        }

        public void Undo()
        {
            _door.Open();
        }
    }
}