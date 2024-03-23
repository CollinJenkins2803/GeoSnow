using GeoSnowAPI.Entities;

namespace GeoSnowAPI.Repositories
{
    public interface INewsletterService
    {
        public Task<bool> CheckEmailSubscription(string email);
    }
}

