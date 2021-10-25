using System;
using System.Collections.Generic;
using System.Reflection;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;
using WebApiDemo.Infrastructure.IRepositories;
using WebApiDemo.Infrastructure.IRepositories.Generic;

namespace WebApiDemo.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IApiResponseRepository _apiResponseRepository;

        public CustomerRepository(IApiResponseRepository apiResponseRepository)
        {

            _apiResponseRepository = apiResponseRepository;
           
        }

        public ApiResponse Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public ApiResponse List()
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

        public ApiResponse Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
