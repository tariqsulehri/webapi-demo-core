using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Dtos;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;

namespace WebApiDemo.Infrastructure.IRepositories
{
    public interface ICountryRepository
    {
        ApiResponse Add(Country country);
        ApiResponse List();
        ApiResponse Update(Country country);
    }
}
