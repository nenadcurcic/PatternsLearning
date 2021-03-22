using System;
using System.Globalization;

namespace DateTimeTrials
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string date = "2020-12-05 00:00:00.000";
            string datePicker = "02.05.2020";

            CultureInfo cultureSR = new CultureInfo("sr", false);
            CultureInfo cultureEN = new CultureInfo("en", false);

            DateTime myDate = DateTime.Parse(datePicker);
            Console.WriteLine("input date: " + date);
            Console.WriteLine("============");
            Console.WriteLine("culture: " + cultureSR.Name);
            Console.WriteLine(myDate.ToString(cultureSR));
            Console.WriteLine(myDate.ToString(cultureEN));
            Console.WriteLine("============");
            myDate = DateTime.Parse(date, cultureEN);
            Console.WriteLine("culture: " + cultureEN.Name);
            Console.WriteLine(myDate.ToString(cultureSR));
            Console.WriteLine(myDate.ToString(cultureEN));

            //Console.WriteLine("culture: raw");
            //Console.WriteLine(myDate.ToString("yyyy-dd-MM"));

            //Console.WriteLine(myDate.Date.ToString("dd.MM.yyyy"));
            //Console.WriteLine(myDate.Date.ToString("MM/dd/yyyy"));
            //Console.WriteLine(myDate.Date.ToString("yyyy/MM/dd"));
            Console.ReadKey();
        }
    }
}