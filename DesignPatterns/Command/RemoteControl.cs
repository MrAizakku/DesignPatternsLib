using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    // Invoker: Controls the execution of commands
    class RemoteControl : IInvoker
    {
        private ICommand currentCommand;

        public void SetCommand(ICommand command)
        {
            currentCommand = command;
        }

        public void PressButton()
        {
            if (currentCommand != null)
            {
                currentCommand.Execute();
            }
        }
    }
}
