using ProjectMuseum.Models;

namespace ProjectMuseum.ViewModels
{
    public class BlogDetailVM
    {

        public IEnumerable<Blog> Blogs { get; set; }
        public ICollection<BlogImage> BlogImages { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<BlogComment> BlogComments { get; set; }

    }
}
