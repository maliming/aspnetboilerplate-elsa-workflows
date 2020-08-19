using System.Threading.Tasks;
using Abp.Application.Services;
using ElsaProject.Sessions.Dto;

namespace ElsaProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
