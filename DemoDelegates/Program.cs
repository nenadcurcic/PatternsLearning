using System;
using System.Collections.Generic;

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

            //Predicate, delegate with generic input params and return bool, practicaly Func<T, bool>

            List<User> users = PopulateListusers();

            Predicate<User> adUser = (x) => x.Name.Contains("ad");

            User concreteUser = users.Find(adUser);

            Console.WriteLine(concreteUser.ToString());

            Console.ReadKey();
        }

        private static List<User> PopulateListusers()
        {
            List<User> resultList = new List<User>()
            {
                new User(){Id = 1, Name = "Nenad", ShureName = "Curcic"},
                new User(){Id = 2, Name = "Marko", ShureName = "Markovic"},
                new User(){Id = 3, Name = "Janko", ShureName = "Jankovic"},
                new User(){Id = 4, Name = "Zdravko", ShureName = "Jankovic"},
            };

            return resultList;
        }

        //expression body format
        private static bool IsGreater(int x, int y) => x > y;

        private static double SubShift(double x, double y)
        {
            x += 0.3;
            y += 0.2;
            return x + y;
        }

        internal class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string ShureName { get; set; }

            public override string ToString()
            {
                return $"Id: {Id}, name: {Name}, shurename: {ShureName}";
            }
        }

    }
}