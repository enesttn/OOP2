using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
     class Program
    {
        static void Main(string[] args)
        {

            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CompanyNo = "123";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.TcNo = "11111111111";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CompanyNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            //Real Customer - Legal Customer
            // SOLID

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

           
        }
    }
}
