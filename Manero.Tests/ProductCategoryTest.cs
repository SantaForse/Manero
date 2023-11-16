
namespace Manero.Tests
{
    public class ProductCategoryTest : IClassFixture<CustomWebApplicationFactory>
    {

        private readonly HttpClient _client;

        public ProductCategoryTest(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }


        [Fact]
        public async Task DressesPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Dresses");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task PantsPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Pants");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task ShoesPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Shoes");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task HoodiePageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Hoodie");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task AccessoriesPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Category/Accessories");
            response.EnsureSuccessStatusCode();
        }

    }
}
