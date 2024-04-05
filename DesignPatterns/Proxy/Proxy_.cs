using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    // Proxy
    public class Proxy_ : ISubject
    {
        private RealSubject realSubject;

        public void Request()
        {
            // Lazy initialization: Create the real subject only when needed
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            // Perform additional operations or access control
            Console.WriteLine("Proxy: Logging, checking permissions, or other pre-processing.");

            // Delegate the request to the real subject
            realSubject.Request();

            // Perform additional operations or access control
            Console.WriteLine("Proxy: Logging, checking permissions, or other post-processing.");
        }
    }
}
