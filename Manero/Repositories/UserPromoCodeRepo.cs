using Manero.Data;
using Manero.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace Manero.Repositories
{
    public class UserPromoCodeRepo : DbContextRepository<UserPromoCodeEntity>
    {
        public UserPromoCodeRepo(ProductDbContext context) : base(context)
        {
        }
    }
}
