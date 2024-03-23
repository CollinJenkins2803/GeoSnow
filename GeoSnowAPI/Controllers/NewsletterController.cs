using GeoSnowAPI.Entities;
using GeoSnowAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Globalization;

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
        [HttpPost("add-subscriber")]
        public async Task<ActionResult> AddSubscriber([FromBody] string email)
        {
            string result = await _newsletterService.AddSubscriber(email);
            if (result == "Subscriber added successfully.")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("remove-subscriber")]
        public async Task<ActionResult> RemoveSubscriber([FromBody] string email)
        {
            if (string.IsNullOrWhiteSpace(email)){
                return BadRequest("Email is required.");
            }
            String result = await _newsletterService.RemoveSubscriber(email);
            if(result == "Subscriber removed succesfully.")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
