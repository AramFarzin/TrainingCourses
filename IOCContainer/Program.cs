using System;
using Unity;
using Unity.Injection;
using Unity.Resolution;

namespace IOCContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICustomerDataAccess, CustomerDataAccess>();

            Console.WriteLine(unityContainer.Resolve<CustomerBussinessLogic>().GetCustomerName("aaa"));
            Console.ReadLine();


            unityContainer.RegisterType<ICustomerDataAccess, CustomerDataAccess2>("Second");
            Console.WriteLine(unityContainer.Resolve<CustomerBussinessLogic>("Second").GetCustomerName("bbb"));
            Console.ReadLine();


            Console.WriteLine(unityContainer.Resolve<CustomerBussinessLogic>("Second", new DependencyOverride<ICustomerDataAccess>(unityContainer.Resolve<ICustomerDataAccess>())).GetCustomerName("bbb"));
            Console.ReadLine();
        }
    }
}
