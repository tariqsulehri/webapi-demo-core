using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Core.Dtos
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name {get;set;}
        public string Prefix { get; set;}
        public int RegionId { get; set; }
        public string Region { get; set; }
    }
}
