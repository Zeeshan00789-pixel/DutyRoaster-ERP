using DutyRoaster.Services;
using Microsoft.AspNetCore.Mvc;

namespace DutyRoaster.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController : ControllerBase
    {
        private readonly CommonService _commonService;

        public CommonController(CommonService commonService)
        {
            _commonService = commonService;
        }

        [HttpGet("companies")]
        public async Task<IActionResult> GetCompanies()
        {
            var result = await _commonService.GetCompaniesAsync();

            return Ok(result);
        }

        [HttpGet("branches")]
        public async Task<IActionResult> GetBranches(Guid companyIdGUID)
        {
            var result = await _commonService
                .GetBranchesAsync(companyIdGUID);

            return Ok(result);
        }
    }
}