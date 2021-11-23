namespace ExtensionMethods
{
    //note 1: extension method must be static and in static class
    //note 2: extension method must contain first argument this and class that we extensioning
    internal static class FizzBuzzClass
    {
        internal static string FizzBuzz(this int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            } else if (value % 5 == 0)
            {
                return "Fizz";
            } 
            else if (value % 3 == 0)
            {
                return "Buzz";
            } 
            else
            {
                return value.ToString();
            }
        }
    }
}
