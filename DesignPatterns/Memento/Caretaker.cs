using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    // Caretaker: Manages the mementos
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return mementos[index];
        }
    }
}
