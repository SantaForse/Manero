using Manero.Data;
using Manero.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace Manero.Repositories
{
    public class PromoCodeRepo : DbContextRepository<PromoCodeEntity>
    {
        public PromoCodeRepo(ProductDbContext context) : base(context)
        {
        }
    }
}
