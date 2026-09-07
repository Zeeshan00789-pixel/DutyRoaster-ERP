using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProjectName.Models
{
    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        public long UserProfileId { get; set; }
        public Guid? ApplicationUserId { get; set; }

        public string? LoginName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? RoleId { get; set; }
        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }
        public Guid CompanyIdGUID { get; set; }
        public Guid BranchIdGUID { get; set; }
        public string? Address { get; set; }

        
        public int? CityId { get; set; }
        public string? PasswordHash { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? OldPassword { get; set; }
        public string? ProfilePicture { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        [Required]
        public bool Cancelled { get; set; }
    }
}