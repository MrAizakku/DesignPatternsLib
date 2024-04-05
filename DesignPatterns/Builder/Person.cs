using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }

}
