using CoffeShop.Abstracts;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Adapters
{
    public class ServisAdapters : ICustomerCheckService
    {
        public bool ChechifRealPerson(Customer customer)
        {
             KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBrith.Year);

        }
    }
}
