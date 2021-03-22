using System;

namespace DelegatesExample
{
    internal static class Program
    {
        public delegate int DelegateMethod(int x, int y);

        public delegate void DelegateMulticast(int x, int y);

        public static void Main()
        {
            //singlecast
            DelegateMethod sabiranje = new DelegateMethod(TwoNumAdd);

            Console.WriteLine(sabiranje(45, 50));

            RunDelegator(TwoNumAdd, 90, 50);
            RunDelegator(TwoNumMinus, 90, 50);

            Console.WriteLine("====================");

            //multicast
            DelegateMulticast del = new DelegateMulticast(TwoNumAdd2);
            del += new DelegateMulticast(TwoNumMinus2);

            del(100, 30);
            Console.WriteLine("====================");
            DelegateMethod delAnonymus = (int a, int b) => a * b;

            Console.WriteLine(delAnonymus(5, 10));

            Console.ReadKey();
        }

        public static int TwoNumAdd(int a, int b)
        {
            return a + b;
        }

        public static void TwoNumAdd2(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static int TwoNumMinus(int a, int b)
        {
            return a - b;
        }

        public static void TwoNumMinus2(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void RunDelegator(DelegateMethod method, int a, int b)
        {
            Console.WriteLine(method(a, b));
        }
    }
}