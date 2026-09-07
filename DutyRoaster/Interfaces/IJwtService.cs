using DutyRoaster.Models;
using DutyRoaster.Interfaces;
using YourProjectName.Models;
namespace DutyRoaster.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(UserProfile user);
    }
}
