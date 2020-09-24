using System;

namespace ExtensionMethods
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            MyClass mc = new MyClass(5);

            mc.ShowPropertyValue();

            mc.IncreaseMyProp(6);

            mc.ShowPropertyValue();

            MySecondClass msc = new MySecondClass(3);

            msc.SHowMySecondClassProp();

            Console.ReadKey();
        }
    }
}