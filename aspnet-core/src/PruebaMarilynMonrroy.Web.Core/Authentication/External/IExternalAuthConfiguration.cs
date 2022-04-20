using System.Collections.Generic;

namespace PruebaMarilynMonrroy.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
