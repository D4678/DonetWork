using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  partial class PartialCustomerOne
    {
        private readonly string _FirstName;
        private string _LastName;

        public string GetFullName()
        {
            return _FirstName + " ," + _LastName;
        }
    }
}
