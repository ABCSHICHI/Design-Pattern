using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_Pattern
{
    /// <summary>
    /// 遥控器的设计
    /// </summary>
    class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;

        private ICommand _undoCommand;

        private readonly static object Lock = new object();//使用lock

        public RemoteControl()
        {
            _onCommands = new ICommand[7];//遥控器上面只有7个插槽(插槽对应Command）
            _offCommands = new ICommand[7];//遥控器上面只有7个插槽(插槽对应Command）
            var noCommand = new NoCommand();
            _undoCommand = noCommand;
            for (int index = 0; index < 7; index++)
            {
                _onCommands[index] = noCommand;
            }
        }

        public void SetCommand(int index, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[index] = onCommand;
            _offCommands[index] = offCommand;
        }

        public void OnButtonWasPushed(int index)
        {
            _onCommands[index].Excute();
            lock (Lock)//加锁
            {
                _undoCommand = _onCommands[index];
            }
        }

        public void OffButtonWasPushed(int index)
        {
            _offCommands[index].Excute();
            lock (Lock)//加锁
            {
                _undoCommand = _offCommands[index];
            }
        }

        public void UndoButtonWasPushed()
        {
            lock (Lock)//加锁
            {
                _undoCommand.Undo();
            }
        }
    }
}
