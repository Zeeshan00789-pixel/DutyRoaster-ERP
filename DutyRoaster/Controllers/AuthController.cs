using DutyRoaster.DTOs;
using DutyRoaster.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DutyRoaster.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        private readonly IJwtService _jwtService;

        public AuthController(IAuthRepository authRepository,
                              IJwtService jwtService)
        {
            _authRepository = authRepository;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _authRepository.LoginAsync(loginDto);

            if (user == null)
            {
                return Unauthorized("Invalid Email or Password");
            }

            var token = _jwtService.GenerateToken(user);

            var response = new LoginResponseDto
            {
                Token = token,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserProfileId = user.UserProfileId,
                ExpireAt = DateTime.Now.AddHours(2)
            };

            return Ok(response);
        }
    }
}