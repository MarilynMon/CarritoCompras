using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaMarilynMonrroy.Configuration;

namespace PruebaMarilynMonrroy.Web.Host.Startup
{
    [DependsOn(
       typeof(PruebaMarilynMonrroyWebCoreModule))]
    public class PruebaMarilynMonrroyWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PruebaMarilynMonrroyWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaMarilynMonrroyWebHostModule).GetAssembly());
        }
    }
}
