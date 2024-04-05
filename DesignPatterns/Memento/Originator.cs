using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    // Originator: The object whose state needs to be saved
    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                Console.WriteLine("Setting state to: " + value);
                state = value;
            }
        }

        // Create a memento (snapshot) of the current state
        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        // Restore the state from a memento
        public void RestoreMemento(Memento memento)
        {
            state = memento.State;
        }
    }
}
