using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manero.Tests
{
    public class UserProfileNavigationTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public UserProfileNavigationTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }



        [Fact]
        public async Task UserProfileToUserAddresses_ShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/Account/Manage");

            response.EnsureSuccessStatusCode();
        }


        [Fact]
        public async Task UserProfileToUserddAddresses_ShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/UserProfile/UserOrderHistory");

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task UserProfileToSignOut_ShouldReturnSuccess()
        {
            var response = await _client.GetAsync("/SignOut");

            response.EnsureSuccessStatusCode();
        }
    }
}
