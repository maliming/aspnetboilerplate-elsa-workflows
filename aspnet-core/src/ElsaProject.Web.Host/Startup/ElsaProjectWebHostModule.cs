using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using ElsaProject.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ElsaProject.Web.Host.Startup
{
    [DependsOn(
       typeof(ElsaProjectWebCoreModule))]
    public class ElsaProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ElsaProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ElsaProjectWebHostModule).GetAssembly());

            Register(typeof(Elsa.Dashboard.Areas.Elsa.Controllers.HomeController).GetAssembly());
            Register(typeof(Elsa.WorkflowDesigner.ViewComponents.WorkflowDesignerViewComponent).GetAssembly());
        }

        private void Register(Assembly assembly)
        {
            //Controller
            IocManager.IocContainer.Register(
                Classes.FromAssembly(assembly)
                    .BasedOn<Controller>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition && !type.IsAbstract)
                    .LifestyleTransient()
            );

            //Razor Pages
            IocManager.IocContainer.Register(
                Classes.FromAssembly(assembly)
                    .BasedOn<PageModel>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition && !type.IsAbstract)
                    .LifestyleTransient()
            );

            //ViewComponents
            IocManager.IocContainer.Register(
                Classes.FromAssembly(assembly)
                    .BasedOn<ViewComponent>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                    .LifestyleTransient()
            );
        }
    }
}
