using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaMarilynMonrroy.Authorization;

namespace PruebaMarilynMonrroy
{
    [DependsOn(
        typeof(PruebaMarilynMonrroyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PruebaMarilynMonrroyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PruebaMarilynMonrroyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PruebaMarilynMonrroyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
