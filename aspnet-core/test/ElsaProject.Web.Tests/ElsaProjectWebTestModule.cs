using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ElsaProject.EntityFrameworkCore;
using ElsaProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ElsaProject.Web.Tests
{
    [DependsOn(
        typeof(ElsaProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ElsaProjectWebTestModule : AbpModule
    {
        public ElsaProjectWebTestModule(ElsaProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ElsaProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ElsaProjectWebMvcModule).Assembly);
        }
    }
}