using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    // Concrete Elements
    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("ConcreteElementA: OperationA");
        }
    }
}
