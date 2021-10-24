using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using WebApiDemo.Core.Entities;
using WebApiDemo.Infrastructure.IRepositories;
using WebApiDemo.Infrastructure.IRepositories.Generic;

namespace WebApiDemo.Controllers
{
    [Route("api/v1/country")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
       

        public CountryController( ICountryRepository countryRepository)                               
        {
            _countryRepository = countryRepository;
        }

        ///<summary>
        ///Get The List of all countries
        ///</summary>
        ///<return>List of All Countries </return>
        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _countryRepository.List();
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

        ///<summary>
        ///Create Country
        ///</summary>
        ///<remarks>
        ///    Sample Parameter for Post
        ///    
        ///     POST: api/v1/country{
        ///         name:"Pakistan",
        ///         DialCode:"+92",
        ///         regionId: 
        ///     }
        ///</remarks>
        ///<param name="country"></param>

        [HttpPost]
        public IActionResult Post([FromForm] Country  country)
        {
            try
            {
                var result = _countryRepository.Add(country);
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
