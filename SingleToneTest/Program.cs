using System;

namespace SingletoneTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var organization = SingleOrganization.GetOrganization();
            organization.Name = "Sadad";

            var org = SingleOrganization.GetOrganization();
            Console.WriteLine(org.Name);

            Console.ReadLine();
        }
    }
}