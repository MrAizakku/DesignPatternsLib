using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    // Concrete Decorator B
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Concrete Decorator B: Added Behavior");
        }
    }
}
