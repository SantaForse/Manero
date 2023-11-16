using manero.Data;
using Manero.Data;
using Manero.Models.Entities;
using Manero.Repositories;
using Manero.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manero.Tests
{
	public class UserPaymentCardsTest
	{
		//Test by Anton
		[Fact]
		public async Task GetUserPaymentCards_ReturnsAllCards()
		{
			// Arrange
			var cardsDbOptions = new DbContextOptionsBuilder<ProductDbContext>()
				.UseInMemoryDatabase(databaseName: "PaymentCards_ReturnsAllCards_Database")
				.Options;

			var appDbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
				.UseInMemoryDatabase(databaseName: "Users_ReturnsAllAddresses_Database")
				.Options;

			//adds user
			using (var context = new ApplicationDbContext(appDbOptions))
			{
				context.Users.Add(new IdentityUser { Id = "20", Email = "email@domain.com" });
				context.SaveChanges();
			}

			//adds payment cards and userPaymentCards
			using (var context = new ProductDbContext(cardsDbOptions))
			{
				context.PaymentCards.Add(new PaymentCardEntity { Id = 1, Name = "Tratt Trattson", CardNumber = "1234 5678 1234", ExpireDate = "10/12", CVVCode = 123 });
				context.PaymentCards.Add(new PaymentCardEntity { Id = 2, Name = "Lind Lindson", CardNumber = "2345 1234 2345", ExpireDate = "11/12", CVVCode = 456 });

				context.UserPaymentCards.Add(new UserPaymentCardEntity { UserId = "20", PaymentCardId = 1 });
				context.UserPaymentCards.Add(new UserPaymentCardEntity { UserId = "20", PaymentCardId = 2 });
				context.SaveChanges();
			}

			//thanks to Christian who helped me get this working
			using (var context = new ProductDbContext(cardsDbOptions))
			{
				var addressRepo = new AddressRepo(context);
				var userAddressRepo = new UserAddressRepo(context);
				var promoCodeRepo = new PromoCodeRepo(context);
				var userPromoCodeRepo = new UserPromoCodeRepo(context);
				var paymentCardRepo = new PaymentCardRepo(context);
				var userPaymentCardRepo = new UserPaymentCardRepo(context);


				//old code
				var service = new UserService(context, promoCodeRepo, userPromoCodeRepo, userAddressRepo, paymentCardRepo, userPaymentCardRepo);

				// Act
				var result = await service.GetPaymentCardByUserId("20");

				// Assert
				Assert.NotNull(result);
				//Check if we gt 2 addresses from user
				Assert.Equal(2, result.Count);

			}
		}
	}
}
