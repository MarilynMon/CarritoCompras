using Abp.MultiTenancy;
using PruebaMarilynMonrroy.Authorization.Users;

namespace PruebaMarilynMonrroy.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
