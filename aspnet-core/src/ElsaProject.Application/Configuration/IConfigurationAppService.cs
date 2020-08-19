using System.Threading.Tasks;
using ElsaProject.Configuration.Dto;

namespace ElsaProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
