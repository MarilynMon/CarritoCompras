using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PruebaMarilynMonrroy.Authorization.Roles;
using PruebaMarilynMonrroy.Authorization.Users;
using PruebaMarilynMonrroy.MultiTenancy;
using PruebaMarilynMonrroy.ProductsEntity;

namespace PruebaMarilynMonrroy.EntityFrameworkCore
{
    public class PruebaMarilynMonrroyDbContext : AbpZeroDbContext<Tenant, Role, User, PruebaMarilynMonrroyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Persona> Persona { get; set; }

        public PruebaMarilynMonrroyDbContext(DbContextOptions<PruebaMarilynMonrroyDbContext> options)
            : base(options)
        {
        }
    }
}
