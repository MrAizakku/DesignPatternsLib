using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    // Concrete Handler
    public class ConcreteHandler : IHandler
    {
        private IHandler successor;
        private int REQUEST_MAX => 10;

        public void SetSuccessor(IHandler successor)
        {
            this.successor = successor;
        }

        public void HandleRequest(int request)
        {
            if (request <= REQUEST_MAX)
            {
                Console.WriteLine($"Request {request} handled by ConcreteHandler.");
            }
            else if (successor != null)
            {
                Console.WriteLine($"Request {request} being passed to successor.");
                successor.HandleRequest(request);
            }
            else
            {
                Console.WriteLine($"Request {request} cannot be handled. Request Max = {REQUEST_MAX}.");
            }
        }
    }
}
