using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldDemo
{
    internal static class Program
    {
        private static void Main()
        {
            List<string> names = new List<string>() { "baba", "asad", "basad", "beba", "abba", "neno" };
            List<int> numbers = new List<int>() { 1, 3, 5, 7, 9 };

            //foreach (var item in Iterate(names))
            //{
            //    Console.WriteLine(item);
            //}
            foreach (var item in RunningTotal(numbers))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static IEnumerable<int> RunningTotal(IEnumerable<int> list)
        {
            int total = 0;
            foreach (var item in list)
            {
                total += item;
                yield return total;
            }
        }
        private static IEnumerable Iterate(IEnumerable list)
        {
            foreach (string item in list)
            {
                if (item.Contains("ba"))
                {
                    yield return item;
                }
            }
        }


    }
}