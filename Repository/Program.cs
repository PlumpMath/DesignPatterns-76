using Repository.Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Customer> customerRepo = new CustomerRepository();

            var customer = new Customer { Id = 1, Name = "Tero Testaaja", Address = "Testikatu 1" };
            customerRepo.Add(customer);
            customerRepo.Update(customer);
            customerRepo.Delete(customer);

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
