using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Core.Dtos
{
    public class TelcoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; } 
        public string Region { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }
        public string Prefix { get; set; }
    }
}
