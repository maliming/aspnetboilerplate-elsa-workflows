using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ElsaProject.Authorization.Roles;
using ElsaProject.Authorization.Users;
using ElsaProject.MultiTenancy;

namespace ElsaProject.EntityFrameworkCore
{
    public class ElsaProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ElsaProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ElsaProjectDbContext(DbContextOptions<ElsaProjectDbContext> options)
            : base(options)
        {
        }
    }
}
