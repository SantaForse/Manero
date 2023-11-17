using Manero.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace manero.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }



        //Seeding two default users with User Id's associated to defferebnt Promo codes in UserPromoCodes table - christian 10/11
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //var userId = Guid.NewGuid().ToString();
            //var roleId = Guid.NewGuid().ToString();
                        
            
            var passwordHasherHans = new PasswordHasher<IdentityUser>();
            var userHans = new IdentityUser
            {
                Id = "5ebe6c4c-409c-47fe-bed4-df34cdbd3a8a",
                UserName = "hans@maneromail.com",
                NormalizedUserName = "HANS@MANEROMAIL.COM",
                Email = "hans@maneromail.com",
                NormalizedEmail = "HANS@MANEROMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            userHans.PasswordHash = passwordHasherHans.HashPassword(userHans, "BytMig123!");
            builder.Entity<IdentityUser>().HasData(userHans);



            var passwordHasherTommy = new PasswordHasher<IdentityUser>();
            var userTommy = new IdentityUser
            {
                Id = "a106762b-162f-4e96-9c50-8f6b80298fd1",
                UserName = "tommy@maneromail.com",
                NormalizedUserName = "TOMMY@MANEROMAIL.COM",
                Email = "tommy@maneromail.com",
                NormalizedEmail = "TOMMY@MANEROMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            userTommy.PasswordHash = passwordHasherTommy.HashPassword(userTommy, "BytMig123!");
            builder.Entity<IdentityUser>().HasData(userTommy);
        }
    }
}