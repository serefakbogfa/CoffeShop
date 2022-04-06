using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Abstracts
{
    public interface ICustomerService : IEntity
    {
        void save(Customer customer);
    }
}
    