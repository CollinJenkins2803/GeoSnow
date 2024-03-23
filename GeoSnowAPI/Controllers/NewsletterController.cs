using GeoSnowAPI.Entities;
using GeoSnowAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("{SubscriberID}")]
        public async Task<ActionResult<List<NewsletterSubscriber>>> NewsletterSubscribers(int SubscriberID)
        {
            var subscriberList = await _newsletterService.NewsletterSubscribers(SubscriberID);
            if (subscriberList == null)
            {
                return NotFound();
            }
            return Ok(subscriberList);
        }
    }
}
