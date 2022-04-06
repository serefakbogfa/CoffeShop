using CoffeShop.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Concerts
{
    public class CheckCustomerManager : ICustomerCheckService
    {
        public bool ChechifRealPerson(Customer customer)
        {
            return true;
        }
    }
}   