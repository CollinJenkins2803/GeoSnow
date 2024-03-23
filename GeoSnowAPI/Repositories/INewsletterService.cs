using GeoSnowAPI.Entities;

namespace GeoSnowAPI.Repositories
{
    public interface INewsletterService
    {
        public Task<List<NewsletterSubscriber>> NewsletterSubscribers(int SubscriberID);
    }
}
