using System;

namespace AbstractFactoryTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var entity = new FactoryProducer();
            Console.WriteLine(entity.GetFactory(EntityType.Customer).GetCustomer(CustomerType.Loyal).GetFullName());
            Console.ReadLine();
        }
    }
}