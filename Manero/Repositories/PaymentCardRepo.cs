using Manero.Data;
using Manero.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace Manero.Repositories
{
    public class PaymentCardRepo : DbContextRepository<PaymentCardEntity>
    {
        public PaymentCardRepo(ProductDbContext context) : base(context)
        {
        }
    }
}
