using System.Threading.Tasks;
using PruebaMarilynMonrroy.Models.TokenAuth;
using PruebaMarilynMonrroy.Web.Controllers;
using Shouldly;
using Xunit;

namespace PruebaMarilynMonrroy.Web.Tests.Controllers
{
    public class HomeController_Tests: PruebaMarilynMonrroyWebTestBase
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