using GeoSnowAPI.Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoSnowAPI.Repositories
{
    public interface IForumPostService
    {
        Task<List<ForumPost>> GetPostsByResort(int resortID);
        Task AddForumPost(int resortID, string posterName, string title, string content, int? parentPostID);
        Task DeleteForumPost(int postID);
    }
}
