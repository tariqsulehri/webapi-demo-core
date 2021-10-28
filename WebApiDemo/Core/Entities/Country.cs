using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Core.Entities

{
    public class Country
    {
        public int Id { get; set; } = 0;

        [Required]
        public string Name { get; set; }

        [Required]
        public string DialCode   {get;set;}

        [Required]
        public int RegionId { get; set; }

       // public string Location { get; set; }

    }
}
