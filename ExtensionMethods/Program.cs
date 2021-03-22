using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //MyClass mc = new MyClass(5);

            //mc.ShowPropertyValue();

            //mc.IncreaseMyProp(6);

            //mc.ShowPropertyValue();

            //MySecondClass msc = new MySecondClass(3);

            //msc.SHowMySecondClassProp();

            Element elm1 = new Element()
            {
                Id = 3,
                Name = "marko"
            };

            Element elm2 = new Element()
            {
                Id = 1,
                Name = "janko"
            };

            Element elm3 = new Element()
            {
                Id = 5,
                Name = "darko"
            };

            List<Element> elmList = new List<Element>() { elm1, elm2, elm3 };
            List<Element> sortedList = elmList.OrderBy(elm => elm.Id).ToList();

            foreach (var elem in elmList)
            {
                Console.WriteLine($"id: {elem.Id} name: {elem.Name}");
            }
            Console.WriteLine("====================");
            foreach (var elem in sortedList)
            {
                Console.WriteLine($"id: {elem.Id} name: {elem.Name}");
            }

            Console.WriteLine("====================");
            string data = "/Aministration/UserRights";
            Console.WriteLine(data);
            data = data.ToLower().Trim('/');
            Console.WriteLine(data);




            Console.ReadKey();
        }
    }

    internal class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}