using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApiDemo.Core.Dtos;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;
using WebApiDemo.Infrastructure.IRepositories;
using WebApiDemo.Infrastructure.IRepositories.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApiDemo.Infrastructure.Repositories
{
    public class TelcoRepository : ITelcoRepository
    {

        public List<Telco> telcos = new List<Telco>
        {
              new Telco{Id=1, Name="Mobilink" , CountryId=1},
              new Telco{Id=2, Name="Telenor", CountryId=1},
              new Telco{Id=3, Name="Ufone", CountryId=1}
        };

        private readonly ICountryRepository _countryRepository;
        private readonly IApiResponseRepository _apiResponseRepository;

        public TelcoRepository(IApiResponseRepository apiResponseRepository,
                               ICountryRepository countryRepository,
                               IRegionRepository regionRepository
                    )
        {

            _apiResponseRepository = apiResponseRepository;
            _countryRepository = countryRepository;

        }

        public TelcoRepository()
        {
        }

        public ApiResponse Add(Telco telco)
        {
            throw new NotImplementedException();
        }

        public ApiResponse List()
        {


            try
            {
                ApiResponse countriesResp = _countryRepository.List();
                List<CountryDto> countryList = (List<CountryDto>)(countriesResp.Data);


                var result = telcos.Join(countryList,
                                      telco => telco.CountryId,
                                      country => country.Id,
                                      (telco, country) =>
                             new TelcoDto
                             {
                                 Id = telco.Id,
                                 Name = telco.Name,
                                 CountryId = country.Id,
                                 Country = country.Name,
                                 Prefix = country.Prefix,
                                 RegionId = country.RegionId,
                                 Region = country.Region
                             });


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
                                                 new Error
                                                 {
                                                     Code = e.HResult,
                                                     Description = currentMethodName + " ---> " + e.Message
                                                 }
                );

                return apiResponse;

            }

        }
        public ApiResponse Update(Telco telco)
        {
            throw new NotImplementedException();
        }
    }
}
