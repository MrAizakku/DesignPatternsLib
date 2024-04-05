using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
            Console.WriteLine("ConcreteElementB: OperationB");
        }
    }
}
