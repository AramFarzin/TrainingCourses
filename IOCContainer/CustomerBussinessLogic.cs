using System;

namespace IOCContainer
{
    internal class CustomerBussinessLogic
    {
        private ICustomerDataAccess _dataAccess;

        public CustomerBussinessLogic(ICustomerDataAccess customerDataAccess)
        {
            _dataAccess = customerDataAccess;
        }

        public string GetCustomerName(string name)
        {
            return _dataAccess.GetName(name);
        }
    }
}