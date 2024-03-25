using GeoSnowAPI.Data;
using GeoSnowAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace GeoSnowAPI.Repositories
{
    public class NewsletterService : INewsletterService
    {
        private readonly DbcontextClass _dbContextClass;

        public NewsletterService(DbcontextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        // Author: Collin Jenkins
        public async Task<bool> CheckEmailSubscription(string email)
        {
            var emailParam = new SqlParameter("@Email", email);
            var isSubscribedParam = new SqlParameter
            {
                ParameterName = "@IsSubscribed",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Output
            };

            await _dbContextClass.Database.ExecuteSqlRawAsync("EXEC CheckEmailSubscription @Email, @IsSubscribed OUTPUT", emailParam, isSubscribedParam);

            return (bool)isSubscribedParam.Value;
        }
        // Author: Collin Jenkins
        public async Task<string> AddSubscriber(string email)
        {
            // Check if the email is already subscribed
            bool isSubscribed = await CheckEmailSubscription(email);
            if (isSubscribed)
            {
                return "Email already exists.";
            }
            else
            {
                var emailParam = new SqlParameter("@Email", email);
                await _dbContextClass.Database.ExecuteSqlRawAsync("EXEC AddSubscriber @Email", emailParam);
                return "Subscriber added successfully.";
            }
        }
        // Author: Anthony Marchitto
        public async Task<string> RemoveSubscriber(string email)
        {
            bool isSubscribed = await CheckEmailSubscription(email);
            if (!isSubscribed)
            {
                return "Email does not exist.";
            }
            else
            {
                var emailParam = new SqlParameter("@Email", email);
                await _dbContextClass.Database.ExecuteSqlRawAsync("EXEC RemoveSubscriber @Email", emailParam);
                return "Subscriber removed succesfully.";
            }
        }
    }
}