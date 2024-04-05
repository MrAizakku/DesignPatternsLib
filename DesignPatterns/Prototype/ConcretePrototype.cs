using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    // Concrete prototype
    public class ConcretePrototype : IPrototype
    {
        public int Number { get; set; }

        public IPrototype Clone()
        {
            // Create a shallow copy of the object
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
