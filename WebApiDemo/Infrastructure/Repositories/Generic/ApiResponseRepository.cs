using WebApiDemo.Core.GenericEntiries;
using WebApiDemo.Infrastructure.IRepositories.Generic;

namespace WebApiDemo.Infrastructure.Repositories.Generic
{
    public class ApiResponseRepository : IApiResponseRepository
    {
        public ApiResponse ComponseResponse(int status, string message, object data, Error error)
        {
            ApiResponse apiResponse = new ApiResponse
            {
                Status = status,
                Message = message,
                Data = data,
                Error = new Error
                {
                    Code = error.Code,
                    Description = error.Description,
                    ErrorOtherDescription = error.ErrorOtherDescription
                }
                
            };

            return apiResponse;

        }

        public ApiResponse ComponseResponse(int status, string message, object data)
        {
            ApiResponse apiResponse = new ApiResponse
            {
                Status = status,
                Message = message,
                Data = data
            };

            return apiResponse;

        }
    }
}
