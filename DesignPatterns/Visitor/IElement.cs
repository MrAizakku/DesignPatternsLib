using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    // Element interface
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
