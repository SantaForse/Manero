using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Manero.Models
{
    public class DefaultUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }        
        public string NormalizedEmail { get; set; }
        public string PasswordHash { get; set; }
    }
}
