using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;

namespace WebApiDemo.Infrastructure.IRepositories
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void List(List<Customer> customers);
        void Update(Customer customer);
    }
}
