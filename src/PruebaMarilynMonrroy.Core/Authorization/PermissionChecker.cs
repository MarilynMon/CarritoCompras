using Abp.Authorization;
using PruebaMarilynMonrroy.Authorization.Roles;
using PruebaMarilynMonrroy.Authorization.Users;

namespace PruebaMarilynMonrroy.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
