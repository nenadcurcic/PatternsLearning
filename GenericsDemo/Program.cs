using System;

namespace GenericsDemo
{
    internal static class Program
    {
        private static void Main()
        {
            bool result = MyClass<int>.IsEqual(1, 1);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

    internal static class MyClass<T>
    {
        static internal bool IsEqual(double x, T y)
        {
            Console.WriteLine(y.GetType().ToString());
            return x.Equals(y);
        }
    }
}