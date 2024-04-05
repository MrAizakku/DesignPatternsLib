using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    // Concrete Decorator A
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Concrete Decorator A: Added Behavior");
        }
    }
}
