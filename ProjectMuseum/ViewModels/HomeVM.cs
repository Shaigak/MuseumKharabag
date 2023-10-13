using ProjectMuseum.Models;

namespace ProjectMuseum.ViewModels
{
    public class HomeVM
    {

        public List<Slider> Sliders { get; set; }
        public List<MiddleAbout> MiddleAbouts { get; set; }
        public List<Event> Events { get; set; }
        public List<FirstDeportation> FirstDeportations { get; set; }

        public List<SecondDeportation> SecondDeportations { get; set; }

        public List<MartyrOfAzerbaijan> MartyrOfAzerbaijans { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<BigNewsBanner> BigNewsBanners { get; set; }
    }
}
