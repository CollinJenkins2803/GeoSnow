using GeoSnowAPI.Entities;

namespace GeoSnowAPI.Repositories
{
    public interface INewsletterService
    {
        public Task<bool> CheckEmailSubscription(string email);
        public Task<string>AddSubscriber(string email);
        public Task<string> RemoveSubscriber(string email);
    }
}

