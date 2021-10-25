using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;

namespace WebApiDemo.Infrastructure.IRepositories
{
    public interface ICustomerRepository
    {
        ApiResponse Add(Customer customer);
        ApiResponse List();
        ApiResponse Update(Customer customer);
    }
}
