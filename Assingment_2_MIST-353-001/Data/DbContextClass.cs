using GeoSnowAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Assingment_2_MIST_353_001.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }
        public DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<Resort> RESORT { get; set; }

    }
}
