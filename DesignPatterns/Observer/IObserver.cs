using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    /*
    Defines a one-to-many dependency between objects so that when one object changes its state, all its dependents are notified and updated automatically. It is commonly used in event handling systems.
    */
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    class NewsAgency : IObserver
    {
        public String AgencyName { get; set; }
        public NewsAgency(String name)
        {
            AgencyName = name;
        }
        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
            {
                Console.WriteLine($"{AgencyName} reporting temperature {weatherStation.Temperature} degree celcius.");
                Console.WriteLine();
            }
        }
    }
}
