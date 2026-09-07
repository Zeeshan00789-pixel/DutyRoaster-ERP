using DutyRoaster.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DutyRoaster.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MenuController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Menu API is working");
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetUserMenu(int userId)
        {
            var menus = await _context.UserMenuPermission
                .Where(x =>
                    x.UserId == userId &&
                    x.CanView &&
                    x.Menu != null &&
                    x.Menu.IsActive)
                .Select(x => new
                {
                    Id = x.Menu!.Id,
                    ParentId = x.Menu.ParentId,
                    Name = x.Menu.Name,
                    Icon = x.Menu.Icon,
                    Route = x.Menu.Route,
                    SortOrder = x.Menu.SortOrder
                })
                .OrderBy(x => x.SortOrder)
                .ToListAsync();

            return Ok(menus);
        }
    }
}