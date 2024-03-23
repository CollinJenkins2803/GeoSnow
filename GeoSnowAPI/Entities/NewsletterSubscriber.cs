using System.ComponentModel.DataAnnotations;


namespace GeoSnowAPI.Entities
{
    public class NewsletterSubscriber
    {
        [Key]
        public int SubscriberID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        public DateTime SubscriptionDate { get; set; }
        
    } 
}
