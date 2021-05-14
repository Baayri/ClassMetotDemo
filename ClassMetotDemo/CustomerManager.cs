using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Added");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Deleted");
        }

        public void List(Customer[] customers)
        {
            int i = 1;
            foreach ( Customer customer in customers)
            {
                Console.WriteLine(i + " - " + customer.FirstName + " " + customer.LastName);
                i++;
            }
        }
    }
}
