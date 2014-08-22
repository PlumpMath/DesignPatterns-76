using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Model
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        bool Registered { get; set; }
    }
}
