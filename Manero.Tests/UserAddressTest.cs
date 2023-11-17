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
	public class UserAddressTest
	{
		//Test by Anton
		[Fact]
		public async Task GetUserAddresses_ReturnsAllAddresses()
		{
			// Arrange
			var productDbOptions = new DbContextOptionsBuilder<ProductDbContext>()
				.UseInMemoryDatabase(databaseName: "Addresses_ReturnsAllAddresses_Database")
				.Options;

			var appDbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
				.UseInMemoryDatabase(databaseName: "Users_ReturnsAllAddresses_Database")
				.Options;

			//adds user
			using (var context = new ApplicationDbContext(appDbOptions))
			{
				context.Users.Add(new IdentityUser { Id = "10", Email = "email@gmail.com" });
				context.SaveChanges();
			}

			//adds addresses and userAdresses
			using (var context = new ProductDbContext(productDbOptions))
			{
				context.Addresses.Add(new AddressEntity { Id = 1, Title = "Home", Address = "Jumkilsskogarna" });
				context.Addresses.Add(new AddressEntity { Id = 2, Title = "Work", Address = "Börjeskogarna" });

				context.UserAddresses.Add(new UserAddressEntity { UserId = "10", AddressId = 1 });
				context.UserAddresses.Add(new UserAddressEntity { UserId = "10", AddressId = 2 });
				context.SaveChanges();
			}

			//thanks to Christian who helped me get this working
			using (var context = new ProductDbContext(productDbOptions))
			{
				var addressRepo = new AddressRepo(context);
				var userAddressRepo = new UserAddressRepo(context);
				var promoCodeRepo = new PromoCodeRepo(context);
				var userPromoCodeRepo = new UserPromoCodeRepo(context);
				var paymentCardRepo = new PaymentCardRepo(context);
				var userPaymentCardRepo = new UserPaymentCardRepo(context);


				//old code
				var service = new UserService(context, userAddressRepo, promoCodeRepo, userPromoCodeRepo, paymentCardRepo, userPaymentCardRepo);

				// Act
				var result = await service.GetAddressesByUserId("10");

				// Assert
				Assert.NotNull(result);
				//Check if we gt 2 addresses from user
				Assert.Equal(2, result.Count);

			}
		}
	}
}
