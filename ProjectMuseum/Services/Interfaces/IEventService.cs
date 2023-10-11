using ProjectMuseum.Models;

namespace ProjectMuseum.Services.Interfaces
{
    public interface IEventService
    {

        Task<List<Event>> GetAll();
    }
}
