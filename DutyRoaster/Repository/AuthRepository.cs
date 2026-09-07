using DutyRoaster.Data;
using DutyRoaster.DTOs;
using DutyRoaster.Interfaces;
using DutyRoaster.Models;
using Microsoft.EntityFrameworkCore;
using YourProjectName.Models;

namespace DutyRoaster.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _context;

        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserProfile?> LoginAsync(LoginDto loginDto)
        {
            var user = await _context.UserProfiles
                .FirstOrDefaultAsync(x =>
                    x.LoginName == loginDto.LoginName &&
                    x.Password == loginDto.Password &&
                    x.Cancelled == false);

            return user;
        }




    }
}