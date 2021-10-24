using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.GenericEntiries;

namespace WebApiDemo.Infrastructure.IRepositories.Generic
{
    public interface IApiResponseRepository
    {
        ApiResponse ComponseResponse(int status ,string message, object data, Error error);
        ApiResponse ComponseResponse(int status, string message, object data);
    }
}
