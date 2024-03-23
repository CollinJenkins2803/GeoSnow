using GeoSnowAPI.Entities;
using GeoSnowAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace GeoSnowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsletterController : ControllerBase
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpGet("check-subscription/{email}")]
        public async Task<ActionResult<bool>> CheckEmailSubscription(string email)
        {
            var isSubscribed = await _newsletterService.CheckEmailSubscription(email);
            return Ok(isSubscribed);
        }
    }
}
