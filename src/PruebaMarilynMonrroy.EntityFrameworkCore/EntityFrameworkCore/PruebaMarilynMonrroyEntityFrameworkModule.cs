using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using PruebaMarilynMonrroy.EntityFrameworkCore.Seed;

namespace PruebaMarilynMonrroy.EntityFrameworkCore
{
    [DependsOn(
        typeof(PruebaMarilynMonrroyCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class PruebaMarilynMonrroyEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<PruebaMarilynMonrroyDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        PruebaMarilynMonrroyDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        PruebaMarilynMonrroyDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaMarilynMonrroyEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
