namespace AbstractFactoryTest
{
    internal class LoyalCustomer : ICustomer
    {
        public string GetFullName()
        {
            return "Loyal Customer";
        }
    }
}