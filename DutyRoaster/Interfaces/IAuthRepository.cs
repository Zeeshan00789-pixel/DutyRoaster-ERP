using DutyRoaster.DTOs;
using DutyRoaster.Models;
using YourProjectName.Models;

namespace DutyRoaster.Interfaces
{
    public interface IAuthRepository
    {
        Task<UserProfile?> LoginAsync(LoginDto model);
    }
}