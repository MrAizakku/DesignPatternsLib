using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }

    public class WeatherStation: ISubject
    {
        private List<IObserver> _obsservers;
        public float Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                Notify();
            }
        }
        private float _temperature;
        public WeatherStation() 
        {
            _obsservers = new List<IObserver>();
        }

        public void Attach(IObserver observer) 
        { 
            _obsservers.Add(observer);
        }

        public void Notify()
        {
            _obsservers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }
}
