using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCContainer
{
    class CustomerDataAccess2: ICustomerDataAccess
    {
        public string GetName(string name)
        {
            return name + "2";
        }
    }
}
