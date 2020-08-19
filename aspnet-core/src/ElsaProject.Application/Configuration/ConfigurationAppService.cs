using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ElsaProject.Configuration.Dto;

namespace ElsaProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ElsaProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
