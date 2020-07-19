using System.Collections.Generic;

namespace Observer
{
    public abstract class Publisher
    {
        private List<Subscriber> _observers = new List<Subscriber>();

        public void Attach(Subscriber observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Subscriber observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Subscriber o in _observers)
            {
                o.Update();
            }
        }
    }
}