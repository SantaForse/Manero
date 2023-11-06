using Microsoft.EntityFrameworkCore;
namespace Manero.Models.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string Address { get; set; } = null!;

        public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();
    }
}


