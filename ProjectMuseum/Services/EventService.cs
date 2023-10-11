using Microsoft.EntityFrameworkCore;
using ProjectMuseum.Data;
using ProjectMuseum.Models;
using ProjectMuseum.Services.Interfaces;

namespace ProjectMuseum.Services
{
    public class EventService : IEventService
    {

        private readonly AppDbContext _context;


        public EventService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetAll()
        {
            return await _context.Events.Where(m => !m.SoftDelete).ToListAsync();
        }
    }
}
