using GeoSnowAPI.Data;
using GeoSnowAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace GeoSnowAPI.Repositories
{
    public class NewsletterService : INewsletterService
    {
        private readonly DbcontextClass _dbContextClass;

        public NewsletterService(DbcontextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<NewsletterSubscriber>> NewsletterSubscribers(int SubscriberID)
        {
            var param = new SqlParameter("@SubscriberID", SubscriberID);
            var SubscriberList = await Task.Run(() => _dbContextClass.NewsletterSubscribers.FromSqlRaw("NewsletterSubscribers @SubscriberID", param).ToListAsync());
            return SubscriberList;
        }
    }
}
