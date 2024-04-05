using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    // Handler interface
    public interface IHandler
    {
        void SetSuccessor(IHandler successor);
        void HandleRequest(int request);
    }
}
