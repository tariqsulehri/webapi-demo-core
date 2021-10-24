using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Infrastructure.IRepositories;

namespace WebApiDemo.Infrastructure.Repositories
{
    public class RegionRepository : IRegionRepository
    {

        public List<Region> regions = new List<Region>
        {
              new Region{Id=1, Name="Europe"},
              new Region{Id=2, Name="Aisa"},
              new Region{Id=3, Name="Africa"},
              new Region{Id=4, Name="Middle East"},
              new Region{Id=5, Name="America"}

        };

        public void Add(Region region)
        {
            throw new NotImplementedException();
        }

        public List<Region> List()
        {
            return regions.ToList();
        }

        public void Update(Region region)
        {
            throw new NotImplementedException();
        }
    }
}
