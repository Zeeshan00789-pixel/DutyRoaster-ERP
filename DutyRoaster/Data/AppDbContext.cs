using DutyRoaster.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using YourProjectName.Models;

namespace DutyRoaster.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<ProjectInfo> ProjectInfos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserMenuPermission> UserMenuPermission { get; set; }
        public DbSet<Menu> Menu { get; set; }


    }
}