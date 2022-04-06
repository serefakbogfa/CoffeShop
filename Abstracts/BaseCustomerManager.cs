using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Abstracts
{
   public class BaseCustomerManager : ICustomerService
    {
        public virtual void save(Customer customer)
        {
            Console.WriteLine("save db" , customer.FirstName);
        }

       
    }
}
