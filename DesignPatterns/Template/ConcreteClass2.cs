using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    // Concrete subclass 2
    public class ConcreteClass2 : AbstractClass
    {
        protected override void Operation1()
        {
            Console.WriteLine("ConcreteClass2: Operation1");
        }

        protected override void Operation2()
        {
            Console.WriteLine("ConcreteClass2: Operation2");
        }

        protected override void Operation3()
        {
            Console.WriteLine("ConcreteClass2: Operation3");
        }
    }
}
