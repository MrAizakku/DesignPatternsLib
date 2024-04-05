using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    // Invoker interface
    interface IInvoker
    {
        void SetCommand(ICommand command);
        void PressButton();
    }
}
