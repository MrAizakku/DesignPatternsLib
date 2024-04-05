using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    // Leaf
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
