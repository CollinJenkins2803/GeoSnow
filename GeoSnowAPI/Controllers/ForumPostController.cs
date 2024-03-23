using Microsoft.AspNetCore.Mvc;
using GeoSnowAPI.Entities;
using GeoSnowAPI.Repositories;

namespace GeoSnowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private readonly IForumPostService _forumService;

        public ForumController(IForumPostService forumService)
        {
            _forumService = forumService;
        }

        [HttpGet("posts-by-resort/{resortID}")]
        public async Task<ActionResult<List<ForumPost>>> GetPostsByResort(int resortID)
        {
            var posts = await _forumService.GetPostsByResort(resortID);
            return Ok(posts);
        }
    }
}