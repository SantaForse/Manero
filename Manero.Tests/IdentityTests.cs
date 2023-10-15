using Microsoft.Net.Http.Headers;
using System.Net;
using System.Text.RegularExpressions;

namespace Manero.Tests
{
    public class IdentityTests
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;

        public IdentityTests()
        {
            _factory = new CustomWebApplicationFactory();
            _client = _factory.CreateClient();
        }
        private string ExtractAntiForgeryToken(string htmlBody)
        {
            Match match = Regex.Match(htmlBody, @"\<input name=""__RequestVerificationToken"" type=""hidden"" value=""([^""]+)"" \/\>");
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                throw new InvalidOperationException("Anti-forgery token can't be extracted");
            }
        }

        [Fact]
        public async Task LoginPageShouldReturnSuccess()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/Identity/Account/Login");
            response.EnsureSuccessStatusCode();
        }
        [Fact]
        public async Task RegisterPageShouldRegisterUser()
        {
            var client = _factory.CreateClient();

            var initialResponse = await client.GetAsync("/Identity/Account/Register");
            initialResponse.EnsureSuccessStatusCode();

            var antiForgeryToken = ExtractAntiForgeryToken(await initialResponse.Content.ReadAsStringAsync());

            var postRequest = new HttpRequestMessage(HttpMethod.Post, "/Identity/Account/Register");

            postRequest.Headers.Add("Cookie", new CookieHeaderValue("AntiForgeryCookie", antiForgeryToken).ToString());

            postRequest.Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["Input.Email"] = "testuser@test.com",
                ["Input.Password"] = "TestPassword1!",
                ["Input.ConfirmPassword"] = "TestPassword1!",
                ["__RequestVerificationToken"] = antiForgeryToken
            });

            var postResponse = await client.SendAsync(postRequest);

            postResponse.EnsureSuccessStatusCode();
        }
        [Fact]
        public async Task LoginPageShouldLogInUser()
        {
            var client = _factory.CreateClient();

            // Navigate to login page and fetch anti-forgery token
            var initialResponse = await client.GetAsync("/Identity/Account/Login");
            initialResponse.EnsureSuccessStatusCode();
            var antiForgeryToken = ExtractAntiForgeryToken(await initialResponse.Content.ReadAsStringAsync());

            // POST request to login
            var postRequest = new HttpRequestMessage(HttpMethod.Post, "/Identity/Account/Login");
            postRequest.Headers.Add("Cookie", new CookieHeaderValue("AntiForgeryCookie", antiForgeryToken).ToString());
            postRequest.Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["Input.Email"] = "testuser@test.com",
                ["Input.Password"] = "TestPassword1!",
                ["__RequestVerificationToken"] = antiForgeryToken
            });

            var postResponse = await client.SendAsync(postRequest);
            postResponse.EnsureSuccessStatusCode();
            var content = await postResponse.Content.ReadAsStringAsync();
            Assert.Contains("Hello testuser@test.com", content);
        }
        [Fact]
        public async Task RegisterPageShouldFailForExistingEmail()
        {
            var client = _factory.CreateClient();

            var initialResponse = await client.GetAsync("/Identity/Account/Register");
            initialResponse.EnsureSuccessStatusCode();
            var antiForgeryToken = ExtractAntiForgeryToken(await initialResponse.Content.ReadAsStringAsync());

            var firstPostRequest = new HttpRequestMessage(HttpMethod.Post, "/Identity/Account/Register");
            firstPostRequest.Headers.Add("Cookie", new CookieHeaderValue("AntiForgeryCookie", antiForgeryToken).ToString());
            firstPostRequest.Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["Input.Email"] = "existinguser@test.com",
                ["Input.Password"] = "TestPassword1!",
                ["Input.ConfirmPassword"] = "TestPassword1!",
                ["__RequestVerificationToken"] = antiForgeryToken
            });

            var firstResponse = await client.SendAsync(firstPostRequest);
            firstResponse.EnsureSuccessStatusCode();

            var secondPostRequest = new HttpRequestMessage(HttpMethod.Post, "/Identity/Account/Register");
            secondPostRequest.Headers.Add("Cookie", new CookieHeaderValue("AntiForgeryCookie", antiForgeryToken).ToString());
            secondPostRequest.Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["Input.Email"] = "existinguser@test.com",
                ["Input.Password"] = "TestPassword1!",
                ["Input.ConfirmPassword"] = "TestPassword1!",
                ["__RequestVerificationToken"] = antiForgeryToken
            });

            var secondResponse = await client.SendAsync(secondPostRequest);

            var secondContent = await secondResponse.Content.ReadAsStringAsync();
            Assert.Contains("is already taken.", secondContent);
        }


    }
}
