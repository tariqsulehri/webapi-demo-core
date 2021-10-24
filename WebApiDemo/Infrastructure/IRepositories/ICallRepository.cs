using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;

namespace WebApiDemo.Infrastructure.IRepositories
{
    public interface ICallRepository
    {
        public void AddCall(PhoneCall phoneCall);
        public void ListCalls();
        public void ListCallsByPhone(string phone);
        public void ListCallsByPhones(string fromPhone, string toPhone );
        public void ListCallsByDates(DateTime fromDate, DateTime toDate);
    }
}
