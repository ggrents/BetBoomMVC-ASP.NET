using BetBoomMVC.Domain;
using BetBoomMVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BetBoomMVC.Application.Services
{
    public class SportTypeService : ISportTypeService
    {

        private AppDbContext _db;
        public SportTypeService(AppDbContext db)
        {
            _db = db;
        }
      
        public async Task<IEnumerable<SportType>> GetSportTypesAsync()
        {
            var sports = await _db.SportTypes.ToListAsync();
            return sports;
        }

        public async Task<SportType> GetSportTypeByIdAsync(int Id)
        {
            var sport = await _db.SportTypes.FirstOrDefaultAsync(l=>l.Id == Id);
            return sport;
        }
    }
}
