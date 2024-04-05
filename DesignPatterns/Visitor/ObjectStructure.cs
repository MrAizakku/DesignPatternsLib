using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    // Object Structure
    public class ObjectStructure
    {
        private List<IElement> elements = new List<IElement>();

        public void Attach(IElement element)
        {
            elements.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
