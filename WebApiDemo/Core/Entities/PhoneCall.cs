using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Core.Entities
{
    public class PhoneCall
    {
        public int Id { get; set; }
        public Telco fromTelco { get; set;}
        public string FromPhone { get; set; }
        public Telco toTelco { get; set; }
        public string ToPhone { get; set; }
        public  DateTime CallStart {get;set;}
        public  DateTime CallEnd { get; set; }
        public int CallDurationMin { get; set; }
        public int CallDurationSec { get; set; }

    }
}
