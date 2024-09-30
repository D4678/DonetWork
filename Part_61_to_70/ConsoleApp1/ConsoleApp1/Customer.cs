using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string GetFullName()
        {
            return  _FirstName + " ," + _LastName;
        }
    }
}