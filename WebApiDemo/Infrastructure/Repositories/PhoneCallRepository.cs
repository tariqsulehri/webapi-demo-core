using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Infrastructure.IRepositories;

namespace WebApiDemo.Infrastructure.Repositories
{
    public class PhoneCallRepository : ICallRepository
    {
        public void AddCall(PhoneCall phoneCall)
        {
            throw new NotImplementedException();
        }

        public void ListCalls()
        {
            throw new NotImplementedException();
        }

        public void ListCallsByDates(DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public void ListCallsByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public void ListCallsByPhones(string fromPhone, string toPhone)
        {
            throw new NotImplementedException();
        }
    }
}
