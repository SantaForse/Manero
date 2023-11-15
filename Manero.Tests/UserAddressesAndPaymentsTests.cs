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
    public class UserAddressesAndPaymentsTests
    {

        [Fact]
        public void GetAddressesByUserId_ReturnsUserAdresses()
        {

        // Arrange
        var options = new DbContextOptionsBuilder<ProductDbContext>()
                .UseInMemoryDatabase(databaseName: "GetAddressesByUserId_Db")
                .Options;

        var userOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "GetAddressesByUserId_Database")
            .Options;

            using (var context = new ProductDbContext(options))
            {

                context.Addresses.Add(new AddressEntity { Id = 10, Title = "Hometown", Address = "Jumkilsskogen 1337"  });
                context.Addresses.Add(new AddressEntity { Id = 11, Title = "Workoffice", Address = "Storstaden 1443" });

                context.UserAddresses.Add(new UserAddressEntity { UserId = "1", AddressId = 10 });
                context.UserAddresses.Add(new UserAddressEntity { UserId = "1", AddressId = 11 });
      

                context.SaveChanges();
            }

            using (var context = new ApplicationDbContext(userOptions))
            {
                // Adding data to db
                var user = new IdentityUser { Id = "1", Email = "example@domain.com" };
                context.Users.Add(user);

                var service = new UserService(addressRepo);

                // Act
                var result = service.GetAddressesByUserId("1");

                // Assert
                Assert.NotNull(result);

                //Assert.Equal(2, result.Count());

                Assert.Equal(2, result.Result.Count);

               // Assert.Contains(result, p => p.ProductName == "Product2");
            }
        }

    }
}
