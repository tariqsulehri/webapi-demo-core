using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Controllers
{
    [Route("api/v1/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        [HttpGet]
        public string[] Get()
        {
            var env = Environment.GetEnvironmentVariable("ConnectionString:Staging");
            return new string[] { "Tariq", "Nasir",env};
        }


    }
}
