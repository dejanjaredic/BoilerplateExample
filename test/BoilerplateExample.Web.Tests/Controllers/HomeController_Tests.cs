using System.Threading.Tasks;
using BoilerplateExample.Web.Controllers;
using Shouldly;
using Xunit;

namespace BoilerplateExample.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerplateExampleWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
