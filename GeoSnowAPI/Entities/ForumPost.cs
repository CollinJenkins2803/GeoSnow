namespace GeoSnowAPI.Entities

{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class ForumPost
    {
        [Key]
        public int POSTID { get; set; }
        public int? ParentPostID { get; set; }
        [Required]
        public int ResortID { get; set; }
        [Required]
        public string? PosterName { get; set; }
        [Required]
        public string? Title { get; set; }
        [MaxLength(1200)]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime PostDate { get; set; } = DateTime.UtcNow;

    }
}
