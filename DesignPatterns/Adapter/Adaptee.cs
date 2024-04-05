using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    // Adaptee
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee: Specific Request");
        }
    }
}
