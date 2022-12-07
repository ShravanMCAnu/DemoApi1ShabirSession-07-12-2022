using DemoApi1.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoApiController : ControllerBase
    {
        private readonly ISchoolRepository _shopRepository;
        public DemoApiController(ISchoolRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        [HttpGet("GetData")]
        public async Task<IActionResult> GetData()
        {
            var school =  await _shopRepository.GetAllSchool();
            return Ok(school);
           
        }
    }
}
