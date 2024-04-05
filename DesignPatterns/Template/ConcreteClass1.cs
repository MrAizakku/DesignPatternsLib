using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    // Concrete subclass 1
    public class ConcreteClass1 : AbstractClass
    {
        protected override void Operation1()
        {
            Console.WriteLine("ConcreteClass1: Operation1");
        }

        protected override void Operation2()
        {
            Console.WriteLine("ConcreteClass1: Operation2");
        }

        protected override void Operation3()
        {
            Console.WriteLine("ConcreteClass1: Operation3");
        }
    }
}
