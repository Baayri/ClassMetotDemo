using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Muhammed";
            customer1.LastName = "Bayri";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Customer";
            customer2.LastName = "2";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Customer";
            customer3.LastName = "3";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            Console.WriteLine("---------------------");
            Customer[] customers = new Customer[] {customer1, customer2, customer3 };
            customerManager.List(customers);

        }
    }
}
