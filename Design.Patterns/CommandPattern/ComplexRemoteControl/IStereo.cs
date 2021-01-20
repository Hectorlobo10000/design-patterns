namespace CommandPattern.ComplexRemoteControl
{
    public interface IStereo
    {
        void On();
        void SetCD();
        void SetVolume(int value);
        void Off();
    }
}