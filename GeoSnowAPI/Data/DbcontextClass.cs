using GeoSnowAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace GeoSnowAPI.Data
{
    public class DbcontextClass : DbContext
    {
        public DbcontextClass(DbContextOptions<DbcontextClass> options): base(options)
        {

        }
        public DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<Resort> RESORT { get; set; }

    }
}
