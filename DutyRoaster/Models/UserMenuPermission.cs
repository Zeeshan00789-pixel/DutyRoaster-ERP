using YourProjectName.Models;

namespace DutyRoaster.Models
{
    public class UserMenuPermission
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int MenuId { get; set; }

        public bool CanView { get; set; }

        public bool CanAdd { get; set; }

        public bool CanEdit { get; set; }

        public bool CanDelete { get; set; }

        // Navigation
        public UserProfile? User { get; set; }

        public Menu? Menu { get; set; }
    }
}
