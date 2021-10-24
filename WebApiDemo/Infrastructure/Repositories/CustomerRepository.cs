using System;
using System.Collections.Generic;
using WebApiDemo.Core.Entities;
using WebApiDemo.Infrastructure.IRepositories;

namespace WebApiDemo.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void List(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
