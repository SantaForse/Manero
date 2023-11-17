using Manero.Models.Entities;
using Manero.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manero.Tests
{
    public class PagesTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;


        public PagesTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }



        [Fact]
        public async Task MenroFirstPage_ReturnSuccess()
        {
            var response = await _client.GetAsync("/welcome/onboardingFirst");

            response.EnsureSuccessStatusCode();
        }


        [Fact]
        public async Task MenroFirstBoardingPage_ReturnSuccess()
        {
            var response = await _client.GetAsync("/welcome/onboardingSecond");

            response.EnsureSuccessStatusCode();
        }


        [Fact]
        public async Task MenroSecondBoardingPage_ReturnSuccess()
        {
            var response = await _client.GetAsync("/welcome/onboardingThird");

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public void AverageStarIcons_OnProductDetailPage_ShouldBeCorrect()
        {
 
            var model = new ProductPageViewModel
            {
                Reviews = new List<ReviewEntity>
                {
                    new ReviewEntity { Rating = 2 },
                    new ReviewEntity { Rating = 5 },
                }
            };


            var result = GetAverageStarIcons(model);
            Assert.Equal(3, result); 
        }

        private int GetAverageStarIcons(ProductPageViewModel model)
        {
            int averageRating = 0;

            if (model.Reviews.Count > 0)
            {
                averageRating = (int)model.Reviews.Average(review => review.Rating);
            }

            return averageRating;
        }

    }
}
