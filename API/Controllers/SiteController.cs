using API.Data;
using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SiteController : ControllerBase
    {
        private readonly ILogger<SiteController> _logger;
        private readonly ISiteRepository _siteRepository;
        public SiteController(ILogger<SiteController> logger,ISiteRepository siteRepository)
        {
            _logger = logger;
            _siteRepository = siteRepository;
        }

        [HttpGet()]
        public async Task<ActionResult<List<SiteDto>>> GetSites(string search)
        {
            var results = await _siteRepository.GetSites(search);

            if (results == null) return NotFound();

            return Ok(results);
        }
    }
}
