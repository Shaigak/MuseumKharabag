using Microsoft.EntityFrameworkCore;
using ProjectMuseum.Data;
using ProjectMuseum.Models;
using ProjectMuseum.Services.Interfaces;

namespace ProjectMuseum.Services
{
    public class FirstDeportationService : IFirstDeportationService
    {

        private readonly AppDbContext _context;

        public FirstDeportationService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<FirstDeportation>> GetAll()
        {
            return await _context.FirstDeportations.Where(m => !m.SoftDelete).ToListAsync();
        }
    }
}
