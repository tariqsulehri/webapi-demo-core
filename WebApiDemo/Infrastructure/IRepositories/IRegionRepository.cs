using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;

namespace WebApiDemo.Infrastructure.IRepositories
{
    public interface IRegionRepository
    {
        void Add(Region region);
        List<Region> List();
        void Update(Region region);
    }
}
