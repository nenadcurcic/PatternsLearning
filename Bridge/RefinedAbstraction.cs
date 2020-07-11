namespace Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    internal class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}