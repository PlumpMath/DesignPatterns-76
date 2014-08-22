using Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private List<Customer> _repo;

        public CustomerRepository()
        {
            _repo = new List<Customer>();
        }

        public void Add(Customer entity)
        {
            Console.WriteLine("Adding {0}", entity.Name);
            _repo.Add(entity);
        }

        public void Delete(Customer entity)
        {
            Console.WriteLine("Deleting {0}", entity.Name);
            _repo.Remove(entity);
        }

        public void Update(Customer entity)
        {
            // demonstrate slow operation
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Updating {0}", entity.Name);

            var toUpdate = GetById(entity.Id);
            if (toUpdate != null)
            {
                toUpdate.Name = entity.Name;
                toUpdate.Address = entity.Address;
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            Console.WriteLine("Getting all entities ");
            return _repo as IEnumerable<Customer>;
        }

        public Customer GetById(int id)
        {
            Console.WriteLine("Getting entity {0}", id);
            return _repo.FirstOrDefault(c => c.Id == id);
        }
    }
}
