using System;

namespace DemoDelegates
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Func is a delegate that must have return type and up to 16 imput params
            Func<int, int, bool> compare = IsGreater;
            Func<double, double, double> specSub = SubShift;

            //can be used with lambdas
            Func<string, string> capitalizeFirst = (string name) =>
            {
                string firstChar = name.Substring(0, 1);
                string restString = name.Substring(1, name.Length - 1);
                return firstChar.ToUpper() + restString;
            };

            Console.WriteLine($"compare: {compare(2, 3)}");
            Console.WriteLine($"subshift: {specSub(2d, 3d)}");
            Console.WriteLine($"lambda: {capitalizeFirst("nenad")}");

            // Action is a delegate that returns void
            Action<string> message = (string name) => Console.WriteLine($"my name is: {capitalizeFirst(name)}");

            message("nenad");

            Console.ReadKey();
        }

        //expression body format
        private static bool IsGreater(int x, int y) => x > y;

        private static double SubShift(double x, double y)
        {
            x += 0.3;
            y += 0.2;
            return x + y;
        }
    }
}