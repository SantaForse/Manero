using Manero.Data;
using Manero.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace Manero.Repositories
{
    public class AddressRepo : DbContextRepository<AddressEntity>
    {
        public AddressRepo(ProductDbContext context) : base(context)
        {
        }
    }
}
