using Autofac;
using manero.Data;
using Manero.Data;
using Manero.Models.Entities;
using Manero.Repositories;
using Manero.Services;
using Microsoft.EntityFrameworkCore;

namespace Manero.Tests
{
    public class UserProfilePromoCodeTests
    {

        [Fact] //Test if Promo Codes associated with user A by user id are retrieved from database
        public async Task GetPromoCodesByUserAId()
        {

            // Initialize the user IDs of two hypotetical users
            string userA = "5ebe6c4c-409c-47fe-bed4-df34cdbd3a8a";
            string userB = "a106762b-162f-4e96-9c50-8f6b80298fd1"; //User B only for reference



            var productDbOptions = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "Products_Database")
                .Options;



            // Add two example Promo Code items
            using (var _productContext = new ProductDbContext(productDbOptions))
            {
                _productContext.PromoCodes.Add(new PromoCodeEntity
                {
                    Id = 1,
                    ImageUrl = "/static-images/placeholder_promocode.svg",
                    Title = "Acme Co.",
                    Discount = 50,
                    ExpirationDate = "June 1, 2024",
                });
                _productContext.PromoCodes.Add(new PromoCodeEntity
                {
                    Id = 2,
                    ImageUrl = "/static-images/placeholder_promocode.svg",
                    Title = "Barone LLC.",
                    Discount = 30,
                    ExpirationDate = "May 1, 2022",
                });
                _productContext.SaveChanges();
            }



            // Add two assications between users and promo codes in-memory database
            // UserA is assigned one Promo Code and User B is assigned two Promo Codes
            using (var _productContext = new ProductDbContext(productDbOptions))
            {
                _productContext.UserPromoCodes.Add(new UserPromoCodeEntity
                {
                    UserId = "5ebe6c4c-409c-47fe-bed4-df34cdbd3a8a",
                    PromoCodeId = 1,
                });
                _productContext.UserPromoCodes.Add(new UserPromoCodeEntity
                {
                    UserId = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                    PromoCodeId = 1,
                });
                _productContext.UserPromoCodes.Add(new UserPromoCodeEntity
                {
                    UserId = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                    PromoCodeId = 2,
                });
                _productContext.SaveChanges();
            }



            using (var _productContext = new ProductDbContext(productDbOptions))
            {
                var addressRepo = new AddressRepo(_productContext);
                var userAddressRepo = new UserAddressRepo(_productContext);
                var promoCodeRepo = new PromoCodeRepo(_productContext);
                var userPromoCodeRepo = new UserPromoCodeRepo(_productContext);
                var paymentCardRepo = new PaymentCardRepo(_productContext);
                var userPaymentCardRepo = new UserPaymentCardRepo(_productContext);

                var service = new UserService(_productContext, userAddressRepo, promoCodeRepo, userPromoCodeRepo, paymentCardRepo, userPaymentCardRepo);
                   
                var result = await service.GetPromoCodesByUserId(userA);



                // User A were assigned one Promo Code and User B were assigned two Promo Codes.
                // Enquiring User As user id should 1) produce a result, 2) exactly 1 result and 3) that the Title property of that result should contain "Acme Co.".

                // 1)
                Assert.NotNull(result);   
                
                // 2)
                Assert.Equal(1, result.Count());    

                // 3)
                Assert.Contains(result, p => p.Title == "Acme Co."); 
            }
        }
    }
}
