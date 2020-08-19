using System.Threading.Tasks;
using ElsaProject.Models.TokenAuth;
using ElsaProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace ElsaProject.Web.Tests.Controllers
{
    public class HomeController_Tests: ElsaProjectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}