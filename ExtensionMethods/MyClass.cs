namespace ExtensionMethods
{
    internal class MyClass
    {
        internal int _myProperty { get; set; }

        public MyClass(int myProperty)
        {
            _myProperty = myProperty;
        }

        internal int IncreaseMyProp(int x)
        {
            _myProperty += x;
            return _myProperty;
        }
    }
}