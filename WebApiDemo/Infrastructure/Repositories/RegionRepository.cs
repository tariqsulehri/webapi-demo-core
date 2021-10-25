using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;
using WebApiDemo.Infrastructure.IRepositories;
using WebApiDemo.Infrastructure.IRepositories.Generic;
using WebApiDemo.Infrastructure.Repositories.Generic;

namespace WebApiDemo.Infrastructure.Repositories
{
    public class RegionRepository : IRegionRepository
    {

        public List<Region> regions = new List<Region>
        {
              new Region{Id=1, Name="Europe"},
              new Region{Id=2, Name="Aisa"},
              new Region{Id=3, Name="Africa"},
              new Region{Id=4, Name="Middle East"},
              new Region{Id=5, Name="America"}

        };


        private readonly IApiResponseRepository _apiResponseRepository;

        public RegionRepository(IApiResponseRepository apiResponseRepository)
        {
           _apiResponseRepository = apiResponseRepository;
        }


        public ApiResponse Add(Region region)
        {
            throw new NotImplementedException();
        }

        public ApiResponse List()
        {
            try
            {

                var result  = regions.ToList();
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

        public ApiResponse Update(Region region)
        {
            throw new NotImplementedException();
        }
    }
}
