using ProjectMuseum.Models;

namespace ProjectMuseum.Services.Interfaces
{
    public interface IFirstDeportationService
    {
        Task<List<FirstDeportation>> GetAll();
    }
}
