using CoffeShop.Abstracts;
using CoffeShop.Adapters;
using System;

namespace CoffeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.save(new Customer{ DateOfBrith = new DateTime(2001, 01, 17), FirstName = "şeref" , LastName = "akboğa", NationalId=5 });
            Console.ReadLine();
        }
    }
}
