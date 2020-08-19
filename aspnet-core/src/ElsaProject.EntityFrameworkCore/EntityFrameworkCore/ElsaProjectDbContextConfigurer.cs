using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ElsaProject.EntityFrameworkCore
{
    public static class ElsaProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ElsaProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ElsaProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
