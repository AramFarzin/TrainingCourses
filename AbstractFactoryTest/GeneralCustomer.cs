namespace AbstractFactoryTest
{
    internal class GeneralCustomer : ICustomer
    {
        public string GetFullName()
        {
            return "General Customer";
        }
    }
}