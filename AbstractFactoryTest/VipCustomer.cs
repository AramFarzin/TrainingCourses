namespace AbstractFactoryTest
{
    internal class VipCustomer : ICustomer
    {
        public string GetFullName()
        {
            return "Vip Customer";
        }
    }
}