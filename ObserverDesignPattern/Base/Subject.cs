using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Base
{
    public class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DettachObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(Subject subject, object arg)
        {
            _observers.ForEach(ob =>
            {
                ob.Notify(subject, arg);
            });
        }
    }
}
