using System;

namespace Observer
{
    public class ConcreteSubscriber : Subscriber
    {
        private string _name;
        private string _observerState;
        private ConcretePublisher _subject;

        // Constructor

        public ConcreteSubscriber(
          ConcretePublisher subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
              _name, _observerState);
        }

        // Gets or sets subject

        public ConcretePublisher Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}