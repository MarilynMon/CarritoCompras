using System.Threading.Tasks;
using PruebaMarilynMonrroy.Configuration.Dto;

namespace PruebaMarilynMonrroy.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
