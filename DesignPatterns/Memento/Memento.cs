using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    // Memento: Stores the state of the Originator
    public class Memento
    {
        //Encapsulation and externalization of an object's internal state, allowing the object to be restored to this state later.
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
