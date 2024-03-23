using GeoSnowAPI.Data;
using GeoSnowAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace GeoSnowAPI.Repositories
{
    public class ForumPostService: IForumPostService
    {
        private readonly DbcontextClass _dbContext;
        public ForumPostService(DbcontextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ForumPost>> GetPostsByResort(int resortID)
        {
            var resortIdParam = new SqlParameter("@ResortID", resortID);
            return await _dbContext.ForumPosts.FromSqlRaw("EXEC GetPostsByResort @ResortID", resortIdParam).ToListAsync();
        }
        public async Task AddForumPost(int resortID, string posterName, string title, string content, int? parentPostID)
        {
            var resortIdParam = new SqlParameter("@ResortID", resortID);
            var posterNameParam = new SqlParameter("@PosterName", posterName);
            var titleParam = new SqlParameter("@Title", title);
            var contentParam = new SqlParameter("@Content", content);
            var parentPostIdParam = parentPostID.HasValue
                ? new SqlParameter("@ParentPostID", parentPostID.Value)
                : new SqlParameter("@ParentPostID", DBNull.Value);

            await _dbContext.Database.ExecuteSqlRawAsync("EXEC AddForumPost @ResortID, @PosterName, @Title, @Content, @ParentPostID",
                resortIdParam, posterNameParam, titleParam, contentParam, parentPostIdParam);
        }
        public async Task DeleteForumPost(int postID)
        {
            var postIdParam = new SqlParameter("@PostID", postID);
            await _dbContext.Database.ExecuteSqlRawAsync("EXEC DeleteForumPost @PostID", postIdParam);
        }
    }
}
