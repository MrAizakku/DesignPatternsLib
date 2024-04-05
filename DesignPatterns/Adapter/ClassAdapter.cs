using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    // Adapter: Class Adapter (using inheritance)
    public class ClassAdapter : Adaptee, ITarget
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
