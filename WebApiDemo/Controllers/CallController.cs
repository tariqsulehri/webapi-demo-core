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
    [Route("api/v1/calls")]
    [ApiController]
    public class CallController : ControllerBase
    {

        private readonly ICallRepository _callRepository;
        public CallController(ICallRepository callRepository)
        {
            _callRepository = callRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _callRepository.ListCalls();
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
