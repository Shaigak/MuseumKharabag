using Microsoft.EntityFrameworkCore;
using ProjectMuseum.Models;

namespace ProjectMuseum.Data
{
    public class AppDbContext : DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


       
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }

        public DbSet<BlogImage> BlogImages { get; set; }

        public DbSet<BigNewsBanner> BigNewsBanners { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<FirstDeportation> FirstDeportations { get; set; }

        public DbSet<SecondDeportation> SecondDeportations { get; set; }

        public DbSet<MartyrOfAzerbaijan> MartyrOfAzerbaijans { get; set; }

        public DbSet<MiddleAbout> MiddleAbouts { get; set; }







        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
