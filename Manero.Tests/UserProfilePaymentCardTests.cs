using Manero.Data;
using Manero.Models.Entities;
using Manero.Repositories;
using Manero.Services;
using Manero.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Manero.Tests
{
    public class UserProfilePaymentCardTests
    {

        [Fact] //Test adding a Payment Card associated with a user by user id to database
        public async Task AddAndGetPaymentCardByUserAId()
        {

            var productDbOptions = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "Products_Database")
                .Options;



            // Initialize the user ID of a hypotetical user
            string userA = "5ebe6c4c-409c-47fe-bed4-df34cdbd3a8a";

            // Initialize the hypotetical Payment Card information of a card User A wants to add from her User Profile page
            var paymentCard = new PaymentCardAddViewModel()
            {
                CardHolderName = "Kristin Watson",
                CardNumber = "3412 4520 5630 6738",
                CardExpirationDate = "06/24",
                CardCVV = 123
            };



            using (var _productContext = new ProductDbContext(productDbOptions))
            {
                var addressRepo = new AddressRepo(_productContext);
                var userAddressRepo = new UserAddressRepo(_productContext);
                var promoCodeRepo = new PromoCodeRepo(_productContext);
                var userPromoCodeRepo = new UserPromoCodeRepo(_productContext);
                var paymentCardRepo = new PaymentCardRepo(_productContext);
                var userPaymentCardRepo = new UserPaymentCardRepo(_productContext);

                var service = new UserService(_productContext, userAddressRepo, promoCodeRepo, userPromoCodeRepo, paymentCardRepo, userPaymentCardRepo);


                // Adding the Paynemt Card
                var result = await service.AddNewPaymentCard(paymentCard, userA);
                
                // Retrieving the Payment Card from the datbase
                var cards = await service.GetPaymentCardByUserId(userA);


                // If Payment Card were succesfully added to the database, 1) a result should be returned 
                // Enquiring UserAs user id 2) should produce exactly 1 result and 3) the properties of that result should match the information provided when adding that card to the database.


                // 1)
                Assert.NotNull(result);

                // 2)
                Assert.Equal(1, cards.Count());
                
                // 3)
                Assert.Contains(cards, (x =>
                    x.Name == paymentCard.CardHolderName &&
                    x.CardNumber == paymentCard.CardNumber &&
                    x.ExpireDate == paymentCard.CardExpirationDate &&
                    x.CVVCode == paymentCard.CardCVV));
            }
        }
    }
}
