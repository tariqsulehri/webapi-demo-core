using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;

namespace WebApiDemo.Infrastructure.IRepositories
{
    public interface ICallRepository
    {
        ApiResponse AddCall(PhoneCall phoneCall);
        ApiResponse ListCalls();
        ApiResponse ListCallsByPhone(string phone);
        ApiResponse ListCallsByPhones(string fromPhone, string toPhone );
        ApiResponse ListCallsByDates(DateTime fromDate, DateTime toDate);
    }
}
