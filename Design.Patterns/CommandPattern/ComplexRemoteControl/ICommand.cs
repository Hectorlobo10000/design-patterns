
namespace CommandPattern.ComplexRemoteControl
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}