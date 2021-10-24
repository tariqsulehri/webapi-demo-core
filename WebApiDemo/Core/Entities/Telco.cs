using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Core.Entities
{
    public class Telco
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId  { get; set;}
        public Country Country { get; set; }
        
    }
}
