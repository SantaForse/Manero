using Manero.Data;
using Manero.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace Manero.Repositories
{
    public class UserPaymentCardRepo : DbContextRepository<UserPaymentCardEntity>
    {
        public UserPaymentCardRepo(ProductDbContext context) : base(context)
        {
        }
    }
}
