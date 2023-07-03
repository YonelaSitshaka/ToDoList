using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ToDo6.Pages;

public class Index_Tests : ToDo6WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
