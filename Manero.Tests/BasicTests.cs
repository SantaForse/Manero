namespace Manero.Tests
{
    public class BasicTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public BasicTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task HomePageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/");

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task PrivacyPageShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Home/Privacy");

            response.EnsureSuccessStatusCode();
        }
    }
}
