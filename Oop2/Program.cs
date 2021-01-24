using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "1234";
            customer1.Name = "Semih";
            customer1.LastName = "Kun";
            customer1.TcNo = "1234567890";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CompanyName = "S Design";
            customer2.CustomerNumber = "222";
            customer2.Id = 2;
            customer2.TaxNumber = "0987654321";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
                
        }
    }
}
