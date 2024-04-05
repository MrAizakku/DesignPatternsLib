using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    // Concrete Strategies
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing ConcreteStrategyA");
        }
    }
}
