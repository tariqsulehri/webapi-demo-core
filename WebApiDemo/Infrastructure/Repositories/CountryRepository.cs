using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WebApiDemo.Core.Dtos;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;
using WebApiDemo.Infrastructure.IRepositories;
using WebApiDemo.Infrastructure.IRepositories.Generic;

namespace WebApiDemo.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public List<Country> countries = new List<Country>
        {
              new Country{Id=1, Name="Pakistan" ,DialCode="+92", RegionId=2},
              new Country{Id=2, Name="Dubai",DialCode="+971", RegionId=4},
              new Country{Id=3, Name="USA",DialCode="+1", RegionId=5}
        };

        private readonly IRegionRepository _regionRepository;
        private readonly IApiResponseRepository _apiResponseRepository;

        public CountryRepository(IRegionRepository regionRepository, IApiResponseRepository apiResponseRepository)
        {
            _regionRepository = regionRepository;
            _apiResponseRepository = apiResponseRepository;
        }

        ApiResponse ICountryRepository.Add(Country country)
        {
            try
            {
                country.Id = countries.Count() + 1;
                countries.Add(country);
                var result = country;
                var apiResponse = _apiResponseRepository.ComponseResponse(
                                        1, ApplicationMessages.Success,
                                        result,
                                        new Error { }
                );

                return apiResponse;

            }
            catch (Exception e)
            {
                // - - - - - - -  L o g g i n g   E r r o r  - - - - - - - - 
                string className = GetType().FullName;
                string currentMethodName = className + " ---> " + MethodBase.GetCurrentMethod().DeclaringType.Name;
                var apiResponse = _apiResponseRepository.ComponseResponse(
                                                 0, 
                                                 ApplicationMessages.Fail,
                                                 null,
                                                 new Error{
                                                     Code = e.HResult,
                                                     Description = currentMethodName + " ---> " + e.Message

                                                 }
                );

                return apiResponse;
            }
        }

        ApiResponse ICountryRepository.List()
        {
            try
            {
                ApiResponse regionsList = _regionRepository.List();
                List<Region> regions = (List<Region>)(regionsList.Data);

                //var result = countries.Join(regions,
                //                      con => con.RegionId,
                //                      reg => reg.Id,
                //                      (con, reg) =>
                //             new CountryDto
                //             {
                //                 Id = con.Id,
                //                 Name = con.Name,
                //                 Prefix = con.DialCode,
                //                 RegionId =  reg.Id,
                //                 Region = reg.Name
                //             }).ToList();

                var result = (from  con in countries
                               join  reg in regions 
                               on con.RegionId equals reg.Id
                              select new { con, reg }).ToList();


                var apiResponse = _apiResponseRepository.ComponseResponse(
                                        1, ApplicationMessages.Success,
                                        result                                   
                );

                return apiResponse;

            }
            catch (Exception e)
            {
                // - - - - - - -  L o g g i n g   E r r o r  - - - - - - - - 
                string className = GetType().FullName;
                string currentMethodName = className + " ---> " + MethodBase.GetCurrentMethod().DeclaringType.Name;
                var apiResponse = _apiResponseRepository.ComponseResponse(
                                                 0, ApplicationMessages.Fail,
                                                 null,
                                                 new Error{
                                                     Code = e.HResult,
                                                     Description = currentMethodName + " ---> " + e.Message
                                                 }
                );

                return apiResponse;
            }

        }
                      
        ApiResponse ICountryRepository.Update(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
