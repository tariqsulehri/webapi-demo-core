using WebApiDemo.Core.Entities;
using WebApiDemo.Core.GenericEntiries;

namespace WebApiDemo.Infrastructure.IRepositories
{
    public interface ITelcoRepository
    {
        ApiResponse Add(Telco telco);
        ApiResponse List();
        ApiResponse Update(Telco telco);
    }
}

