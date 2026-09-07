namespace DutyRoaster.Models
{
    public class Menu
    {

        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Icon { get; set; }

        public string? Route { get; set; }

        public int SortOrder { get; set; }

        public bool IsActive { get; set; } = true;

        // Parent Menu
        public Menu? Parent { get; set; }

        // Child Menus
        public ICollection<Menu> Children { get; set; } = new List<Menu>();

        // Permissions
        public ICollection<UserMenuPermission> UserMenuPermissions { get; set; }
            = new List<UserMenuPermission>();
    }
}
