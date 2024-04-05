using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    /*
     Ensures that a class has only one instance and provides a global point of access to that instance. Useful for managing a single shared resource or configuration settings.
    */
    public sealed class Singleton_
    {
        private static Singleton_ instance = null;

        // Private constructor to prevent instantiation from other classes
        private Singleton_()
        {
        }

        public static Singleton_ Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton_();
                }
                return instance;
            }
        }

        public void SomeMethod()
        {
            Console.WriteLine("Singleton instance method called.");
        }
    }

}
