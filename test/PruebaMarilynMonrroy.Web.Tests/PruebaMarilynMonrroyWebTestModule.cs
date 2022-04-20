using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaMarilynMonrroy.EntityFrameworkCore;
using PruebaMarilynMonrroy.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PruebaMarilynMonrroy.Web.Tests
{
    [DependsOn(
        typeof(PruebaMarilynMonrroyWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PruebaMarilynMonrroyWebTestModule : AbpModule
    {
        public PruebaMarilynMonrroyWebTestModule(PruebaMarilynMonrroyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaMarilynMonrroyWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PruebaMarilynMonrroyWebMvcModule).Assembly);
        }
    }
}