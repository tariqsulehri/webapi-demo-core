using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiDemo.Infrastructure.IRepositories;

namespace WebApiDemo.Controllers
{
    [Route("api/v1/telco")]
    [ApiController]
    public class TelcoController : ControllerBase
    {
        private readonly ITelcoRepository _telcoRepository;
        public TelcoController(ITelcoRepository telcoRepository)
        {
            _telcoRepository = telcoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _telcoRepository.List();
                return new JsonResult(result);
            }
            catch (Exception)
            {
                var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Something went wrong!")
                };
                throw new HttpResponseException(message);
            }
        }


    }
}
