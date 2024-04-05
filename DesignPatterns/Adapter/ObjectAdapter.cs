using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    // Adapter: Object Adapter (using composition)
    public class ObjectAdapter : ITarget
    {
        private Adaptee adaptee;

        public ObjectAdapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
