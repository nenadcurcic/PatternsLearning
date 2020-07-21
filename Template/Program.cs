using System;

namespace Template
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            // Wait for user

            Console.ReadKey();
        }
    }
}