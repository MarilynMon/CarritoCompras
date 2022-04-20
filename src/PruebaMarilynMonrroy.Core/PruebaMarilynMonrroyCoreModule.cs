using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using PruebaMarilynMonrroy.Authorization.Roles;
using PruebaMarilynMonrroy.Authorization.Users;
using PruebaMarilynMonrroy.Configuration;
using PruebaMarilynMonrroy.Localization;
using PruebaMarilynMonrroy.MultiTenancy;
using PruebaMarilynMonrroy.Timing;

namespace PruebaMarilynMonrroy
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class PruebaMarilynMonrroyCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            PruebaMarilynMonrroyLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = PruebaMarilynMonrroyConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = PruebaMarilynMonrroyConsts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = PruebaMarilynMonrroyConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaMarilynMonrroyCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
