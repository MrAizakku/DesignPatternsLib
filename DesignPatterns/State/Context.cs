using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    // Context
    public class Context
    {
        private IState state;

        public Context(IState initialState)
        {
            state = initialState;
        }

        public void SetState(IState newState)
        {
            state = newState;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
