using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ConcreteFactoryA : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteFactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }

}
