using System.Threading.Tasks;
using Abp.Application.Services;
using ElsaProject.Authorization.Accounts.Dto;

namespace ElsaProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
