using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    // Concrete Command: Commands for turning the light on and off
    class TurnOnCommand : ICommand
    {
        private Light light;

        public TurnOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }
}
