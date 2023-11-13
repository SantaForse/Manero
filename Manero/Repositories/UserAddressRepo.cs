using Manero.Data;
using Manero.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace Manero.Repositories
{
    public class UserAddressRepo : DbContextRepository<UserAddressEntity>
    {
        public UserAddressRepo(ProductDbContext context) : base(context)
        {
        }
    }
}
