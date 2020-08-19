using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ElsaProject.Configuration;
using ElsaProject.Web;

namespace ElsaProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ElsaProjectDbContextFactory : IDesignTimeDbContextFactory<ElsaProjectDbContext>
    {
        public ElsaProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ElsaProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ElsaProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ElsaProjectConsts.ConnectionStringName));

            return new ElsaProjectDbContext(builder.Options);
        }
    }
}
