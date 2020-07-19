using System;

namespace Observer
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Configure Observer pattern

            ConcretePublisher s = new ConcretePublisher();

            s.Attach(new ConcreteSubscriber(s, "X"));
            s.Attach(new ConcreteSubscriber(s, "Y"));
            s.Attach(new ConcreteSubscriber(s, "Z"));

            // Change subject and notify observers

            s.SubjectState = "ABC";
            s.Notify();

            // Wait for user

            Console.ReadKey();
        }
    }
}