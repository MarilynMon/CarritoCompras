using System.Threading.Tasks;
using Abp.Application.Services;
using PruebaMarilynMonrroy.Authorization.Accounts.Dto;

namespace PruebaMarilynMonrroy.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
