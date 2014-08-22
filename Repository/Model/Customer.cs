using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Model
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Registered { get; set; }
    }
}
