using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public Telco telco { get; set; }
    }
}
