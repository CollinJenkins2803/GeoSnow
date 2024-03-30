using Microsoft.AspNetCore.Mvc;
using GeoSnowAPI.Entities;
using GeoSnowAPI.Repositories;

namespace GeoSnowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResortController : ControllerBase
    {
        private readonly IResortService _resortService;

        public ResortController(IResortService resortService)
        {
            _resortService = resortService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<Resort>>> GetAllResorts()
        {
            return Ok(await _resortService.GetAllResorts());
        }

        [HttpGet("{resortID}")]
        public async Task<ActionResult<Resort>> GetResortDetails(int resortID)
        {
            var resort = await _resortService.GetResortDetails(resortID);
            if (resort == null) return NotFound();
            return Ok(resort);
        }

        [HttpGet("searchByRadius")]
        public async Task<ActionResult<List<Resort>>> SearchResortsByRadius(decimal latitude, decimal longitude, int? radius)
        {
            return Ok(await _resortService.SearchResortsByRadius(latitude, longitude, radius));
        }

        [HttpGet("searchByRadiusSingleDate")]
        public async Task<ActionResult<List<Resort>>> SearchResortsByRadiusSingleDate(decimal latitude, decimal longitude, DateTime myDate, int? radius)
        {
            return Ok(await _resortService.SearchResortsByRadiusSingleDate(latitude, longitude, myDate, radius));
        }

        [HttpGet("searchByRadiusDateRange")]
        public async Task<ActionResult<List<Resort>>> ResortSearchByRadiusDateRange(decimal latitude, decimal longitude, DateTime startDate, DateTime endDate, int? radius)
        {
            return Ok(await _resortService.ResortSearchByRadiusDateRange(latitude, longitude, startDate, endDate, radius));
        }

        [HttpPost("addResort")]
        public async Task<ActionResult> AddResort([FromBody] Resort resort)
        {
            await _resortService.AddResort(resort);
            return Ok("Resort added successfully");
        }
    }
}
