using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ConcreteProductA : IProduct
    {
        public void ShowInfo()
        {
            Console.WriteLine("Product A");
        }
    }

    public class ConcreteProductB : IProduct
    {
        public void ShowInfo()
        {
            Console.WriteLine("Product B");
        }
    }

}
