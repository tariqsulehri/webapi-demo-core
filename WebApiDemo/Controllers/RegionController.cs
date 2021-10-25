using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using WebApiDemo.Infrastructure.IRepositories;
using System.Net;

namespace WebApiDemo.Controllers
{
    [Route("api/v1/region")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository _regionRepository;
        public RegionController(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _regionRepository.List();
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
