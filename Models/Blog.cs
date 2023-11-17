namespace FrontToBack_2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int ReplyCount { get; set; } 
        public DateTime dateTime { get; set; }
    }
}
