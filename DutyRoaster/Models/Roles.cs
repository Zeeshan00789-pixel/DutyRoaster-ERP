using YourProjectName.Models;

namespace DutyRoaster.Models
{
    public class Roles
    {
        public int Id { get; set; }

        public string RoleName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        // Navigation
        public ICollection<UserProfile> Users { get; set; } = new List<UserProfile>();
    }
}
