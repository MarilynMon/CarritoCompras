using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PruebaMarilynMonrroy.Configuration.Dto;

namespace PruebaMarilynMonrroy.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PruebaMarilynMonrroyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
