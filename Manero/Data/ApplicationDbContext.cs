using Manero.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace manero.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //var userId = Guid.NewGuid().ToString();
            //var roleId = Guid.NewGuid().ToString();

            var passwordHasher = new PasswordHasher<IdentityUser>();
            var userHans = new IdentityUser
            {
                Id = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                UserName = "hans@maneromail.com",
                NormalizedUserName = "HANS@MANEROMAIL.COM",
                Email = "hans@maneromail.com",
                NormalizedEmail = "HANS@MANEROMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            userHans.PasswordHash = passwordHasher.HashPassword(userHans, "BytMig123!");
            var userTommy = new IdentityUser
            {
                Id = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                UserName = "tommy@maneromail.com",
                NormalizedUserName = "TOMMY@MANEROMAIL.COM",
                Email = "tommy@maneromail.com",
                NormalizedEmail = "TOMMY@MANEROMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            userTommy.PasswordHash = passwordHasher.HashPassword(userTommy, "BytMig123!");
        }
    }
}