using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public interface IPersonBuilder
    {
        /*
         in C#, you can use object initializer syntax to instantiate an object with its properties set without the need for a separate Builder pattern for simple cases
        For more complex objects or when you need to provide a fluent and organized interface for object creation, the Builder pattern is a better fit.
        */
        void SetName(string name);
        void SetAge(int age);
        void SetAddress(string address);
        Person Build();
    }
}
