using Microsoft.AspNetCore.Mvc.Testing;
using simple_webapi_test;
using System.Net;

namespace TestProject
{
  public class UnitTest
  {
    [Fact]
    public async void Test()
    {
      await using var application = new WebApplicationFactory<Program>();
      using var client = application.CreateClient();
      var response = await client.GetAsync("/");
      var data = await response.Content.ReadAsStringAsync();
      Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
  }
}
