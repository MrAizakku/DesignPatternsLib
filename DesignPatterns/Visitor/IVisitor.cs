using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    // Visitor interface
    public interface IVisitor
    {
        void VisitConcreteElementA(ConcreteElementA element);
        void VisitConcreteElementB(ConcreteElementB element);
    }
}
