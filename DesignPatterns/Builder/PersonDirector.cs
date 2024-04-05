using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class PersonDirector
    {
        private IPersonBuilder builder;

        public PersonDirector(IPersonBuilder builder)
        {
            this.builder = builder;
        }

        public Person BuildPerson()
        {
            builder.SetName("John");
            builder.SetAge(30);
            builder.SetAddress("123 Main St");
            return builder.Build();
        }
    }

}
