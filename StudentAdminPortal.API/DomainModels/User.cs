using System.ComponentModel.DataAnnotations;

namespace StudentAdminPortal.API.DomainModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PasswordHashed { get; set; }
        public string? Token { get; set; }
        public Guid? RoleId { get; set; }
        public Role? Role { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime RefreshTOkenExpiryTime { get; set; }


    }
}
