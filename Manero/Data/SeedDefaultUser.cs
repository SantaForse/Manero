using Manero.Models;
using Microsoft.AspNetCore.Identity;

namespace Manero.Data
{
    public class SeedDefaultUser
    {
        public static async Task Initialize(IServiceProvider serviceProvider, UserManager<IdentityUser> userManager)
        {
            var seedUsers = GetSeedUsers();

            foreach (var seedUser in seedUsers)
            {
                await EnsureUserCreated(userManager, seedUser);
            }
        }

        private static List<DefaultUser> GetSeedUsers()
        {
            // Define your seed users here
            return new List<DefaultUser>
        {
            new DefaultUser { Username = "user1", Email = "user1@example.com", PasswordHash = "Password123!" },
            // Add more seed users as needed
        };
        }

        private static async Task EnsureUserCreated(UserManager<IdentityUser> userManager, DefaultUser seedUser)
        {
            var existingUser = await userManager.FindByNameAsync(seedUser.Username);
            if (existingUser == null)
            {
                var newUser = new IdentityUser
                {
                    UserName = seedUser.Username,
                    Email = seedUser.Email,
                };

                await userManager.CreateAsync(newUser, seedUser.PasswordHash);
            }
        }
    }
}
