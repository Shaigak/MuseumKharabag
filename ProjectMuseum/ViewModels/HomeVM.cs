using ProjectMuseum.Models;

namespace ProjectMuseum.ViewModels
{
    public class HomeVM
    {

        public List<Slider> Sliders { get; set; }
        public List<MiddleAbout> MiddleAbouts { get; set; }

        public List<Event> Events { get; set; }
    }
}
