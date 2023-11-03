using Microsoft.AspNetCore.Identity;

namespace Manero.Models.Entities
{
    public class UserEntity
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;


        public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();
    }
}

//public class UserEntity : IdentityUser
//{
//    public string? FirstName { get; set; }
//    public string? LastName { get; set; }
//    public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();



//}