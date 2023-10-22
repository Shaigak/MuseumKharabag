namespace ProjectMuseum.Models
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string About { get; set; }
        public ICollection<BlogImage> Images { get; set; }

        public ICollection<BlogComment> BlogComments { get; set; }


    }
}
