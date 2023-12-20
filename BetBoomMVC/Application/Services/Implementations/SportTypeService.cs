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
    }
}
