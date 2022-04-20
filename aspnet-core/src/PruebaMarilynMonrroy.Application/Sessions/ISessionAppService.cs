using System.Threading.Tasks;
using Abp.Application.Services;
using PruebaMarilynMonrroy.Sessions.Dto;

namespace PruebaMarilynMonrroy.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
