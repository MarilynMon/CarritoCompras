using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PruebaMarilynMonrroy.Authorization;
using PruebaMarilynMonrroy.Authorization.Roles;
using PruebaMarilynMonrroy.Authorization.Users;
using PruebaMarilynMonrroy.Editions;
using PruebaMarilynMonrroy.MultiTenancy;

namespace PruebaMarilynMonrroy.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
