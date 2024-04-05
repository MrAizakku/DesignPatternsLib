using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class PersonBuilder : IPersonBuilder
    {
        private Person person = new Person();

        public void SetName(string name)
        {
            person.Name = name;
        }

        public void SetAge(int age)
        {
            person.Age = age;
        }

        public void SetAddress(string address)
        {
            person.Address = address;
        }

        public Person Build()
        {
            return person;
        }
    }

}
