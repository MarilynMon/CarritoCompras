using Abp.Application.Services;
using PruebaMarilynMonrroy.MultiTenancy.Dto;

namespace PruebaMarilynMonrroy.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

