using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using PruebaMarilynMonrroy.Authorization.Roles;
using PruebaMarilynMonrroy.Authorization.Users;
using PruebaMarilynMonrroy.MultiTenancy;
using Microsoft.Extensions.Logging;
using Abp.Domain.Uow;

namespace PruebaMarilynMonrroy.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory,
            IUnitOfWorkManager unitOfWorkManager)
            : base(options, signInManager, systemClock, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
