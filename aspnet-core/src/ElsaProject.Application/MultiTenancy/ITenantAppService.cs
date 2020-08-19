using Abp.Application.Services;
using ElsaProject.MultiTenancy.Dto;

namespace ElsaProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

