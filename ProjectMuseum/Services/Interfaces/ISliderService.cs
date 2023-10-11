using ProjectMuseum.Models;

namespace ProjectMuseum.Services.Interfaces
{
    public interface ISliderService
    {

        Task<List<Slider>> GetAll();
    }
}
