using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaMarilynMonrroy.Configuration;
using PruebaMarilynMonrroy.EntityFrameworkCore;
using PruebaMarilynMonrroy.Migrator.DependencyInjection;

namespace PruebaMarilynMonrroy.Migrator
{
    [DependsOn(typeof(PruebaMarilynMonrroyEntityFrameworkModule))]
    public class PruebaMarilynMonrroyMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PruebaMarilynMonrroyMigratorModule(PruebaMarilynMonrroyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PruebaMarilynMonrroyMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PruebaMarilynMonrroyConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaMarilynMonrroyMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
