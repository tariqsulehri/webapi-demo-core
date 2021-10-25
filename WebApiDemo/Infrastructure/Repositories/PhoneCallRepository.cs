using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;
using WebApiDemo.Infrastructure.IRepositories;
using WebApiDemo.Infrastructure.IRepositories.Generic;

namespace WebApiDemo.Infrastructure.Repositories
{
    public class PhoneCallRepository : ICallRepository
    {

        private readonly IApiResponseRepository _apiResponseRepository;

        public PhoneCallRepository(IApiResponseRepository apiResponseRepository)
        {

            _apiResponseRepository = apiResponseRepository;

        }

        public ApiResponse AddCall(PhoneCall phoneCall)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListCalls()
        {
            try
            {

                var result = new ApiResponse();
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

        public ApiResponse ListCallsByDates(DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListCallsByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListCallsByPhones(string fromPhone, string toPhone)
        {
            throw new NotImplementedException();
        }
    }
}
