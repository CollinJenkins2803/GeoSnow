using GeoSnowAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoSnowAPI.Repositories
{
    public interface IForumPostService
    {
        Task<List<ForumPost>> GetPostsByResort(int resortID);
    }
}
