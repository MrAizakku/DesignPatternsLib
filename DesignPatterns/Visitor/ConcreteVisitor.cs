using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    // Concrete Visitor
    public class ConcreteVisitor : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine("ConcreteVisitor is visiting ConcreteElementA.");
            element.OperationA();
        }

        public void VisitConcreteElementB(ConcreteElementB element)
        {
            Console.WriteLine("ConcreteVisitor is visiting ConcreteElementB.");
            element.OperationB();
        }
    }
}
