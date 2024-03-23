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
    }
}
