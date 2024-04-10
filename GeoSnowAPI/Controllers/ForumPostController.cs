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

        /* 
         [HttpPost("add-forum-post")]
         public async Task<IActionResult> AddForumPost([FromBody] int resortId, string posterName, string postTitle, string postContent, int? parentPostID = null)
         {
             await _forumService.AddForumPost(resortId, posterName, postTitle, postContent, parentPostID);
             return Ok("Forum post added successfully");
         }
         */

        [HttpPost("add-forum-post")]
        public async Task<IActionResult> AddForumPost([FromBody] ForumPost forumPost)
        {
            await _forumService.AddForumPost(forumPost.ResortID, forumPost.PosterName, forumPost.Title, forumPost.Content, forumPost.ParentPostID);
            return Ok("Forum post added successfully");
        }



        [HttpDelete("delete-forum-post/{postID}")]
        public async Task<IActionResult> DeleteForumPost(int postID)
        {
            await _forumService.DeleteForumPost(postID);
            return Ok("Forum post deleted successfully");
        }
    }
}