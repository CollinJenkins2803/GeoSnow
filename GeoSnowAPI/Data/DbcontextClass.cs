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
    }
}
