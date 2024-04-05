using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    // Abstract class with a template method
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
            Operation3();
        }

        protected abstract void Operation1();
        protected abstract void Operation2();
        protected abstract void Operation3();
    }
}
