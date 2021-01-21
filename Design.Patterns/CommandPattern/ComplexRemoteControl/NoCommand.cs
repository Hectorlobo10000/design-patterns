namespace CommandPattern.ComplexRemoteControl
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}