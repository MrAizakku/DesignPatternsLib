using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("ConcreteStateB is handling the request.");
            // Optionally, you can change the state by calling context.SetState(newState)
        }
    }
}
