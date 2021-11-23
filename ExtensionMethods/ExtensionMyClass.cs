using System;

namespace ExtensionMethods
{
    internal static class ExtensionMyClass
    {
        static internal void ShowPropertyValue(this MyClass input)
        {
            Console.WriteLine($"My extension for display prop is: {input._myProperty}");
        }

        static internal void IncreasePropertyValue(this MyClass input, int increment)
        {
            Console.WriteLine($"My increased extension for display prop is: {input._myProperty + increment}");
        }

        static internal void SHowMySecondClassProp(this MySecondClass input)
        {
            Console.WriteLine($"My other class ext method show prop: {input.MyProperty}");
        }
    }
}