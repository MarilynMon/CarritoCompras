using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PruebaMarilynMonrroy.EntityFrameworkCore
{
    public static class PruebaMarilynMonrroyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PruebaMarilynMonrroyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PruebaMarilynMonrroyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
