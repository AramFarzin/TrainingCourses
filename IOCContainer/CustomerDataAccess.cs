using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCContainer
{
    class CustomerDataAccess: ICustomerDataAccess
    {
        public string GetName(string name)
        {
            return name;
        }
    }
}
