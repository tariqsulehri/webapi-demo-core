using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;

namespace WebApiDemo.Infrastructure.IRepositories
{
    public interface IRegionRepository
    {
        ApiResponse Add(Region region);
        ApiResponse List();
        ApiResponse Update(Region region);
    }
}
