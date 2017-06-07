using Nancy;
using Nancy.Testing;
using Shouldly;
using Xunit;

namespace WebApplication1.Tests
{
    public class UnitTest1
    {
        private static Browser Browser => new Browser(with => { with.Module<HomeModule>(); });

        [Fact]
        public void TestMethod1()
        {
            // Arrange.

            // Act.
            var response = Browser.Get("/");

            // Assert.
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }

        [Fact]
        public void TestMethod2()
        {
            // Arrange.

            // Act.
            var result = Browser.Post("/", with =>
            {
                with.FormValue("age", "1");
                with.FormValue("name", "han solo");
            });

            // Assert.
            result.StatusCode.ShouldBe(HttpStatusCode.Created);
        }
    }
}