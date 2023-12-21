using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Domain;
using BetBoomMVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BetBoomMVC.Application.Services.Implementations
{
    public class LeagueService : ILeagueService
    {
        private AppDbContext _db;
        public LeagueService(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<League>> GetLeaguesBySportIdAsync(int SportTypeId)
        {
            var leagues = await _db.Leagues.Where(l=> l.SportTypeId == SportTypeId).ToListAsync();
            return leagues;
        }
    }
}
