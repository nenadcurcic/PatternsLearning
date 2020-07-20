using System;

namespace State
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Setup context in a state

            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state

            c.Request();
            c.Request();
            c.Request();
            c.Request();

            // Wait for user

            Console.ReadKey();
        }
    }
}