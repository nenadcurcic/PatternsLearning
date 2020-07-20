using System;

namespace Strategy
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Context context;

            // Three contexts following different strategies

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            // Wait for user

            Console.ReadKey();
        }
    }
}