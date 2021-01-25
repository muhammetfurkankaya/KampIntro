using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.CustomerId = "12345";
            customer1.Name = "Engin";
            customer1.LastName = "Demirog";
            customer1.TcNo = "1234567890";


            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerId = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



            
        }
    }
}
