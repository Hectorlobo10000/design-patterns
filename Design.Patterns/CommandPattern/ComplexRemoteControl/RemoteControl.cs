using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.ComplexRemoteControl
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {

            StringBuilder stringuBuilder = new StringBuilder();
            stringuBuilder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringuBuilder.Append($"[slot {i}] {_onCommands[i].GetType().FullName} {_offCommands[i].GetType().FullName} \n");
            }

            return stringuBuilder.ToString();

            //return base.ToString();
        }
    }
}
