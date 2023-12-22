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

        public async Task<League> GetLeagueByIdAsync(int LeagueId)
        {
            var league = await _db.Leagues.FirstOrDefaultAsync(l=>l.Id == LeagueId);
            return league;
        }

        public async Task<IEnumerable<League>> GetLeaguesByLeagueIdAsync(int LeagueId)
        {
            var league = await _db.Leagues.FirstOrDefaultAsync(l => l.Id == LeagueId);
            var leagues = await _db.Leagues.Where(l => l.SportTypeId == league.SportTypeId).ToListAsync();
            return leagues;
        }

        public async Task<IEnumerable<League>> GetLeaguesByEventIdAsync(int EventId)
        {
            var _event = await _db.Events.FirstOrDefaultAsync(l => l.Id == EventId);
            var league = await _db.Leagues.FirstOrDefaultAsync(l => l.Id == _event.LeagueId);
            var leagues = await _db.Leagues.Where(l => l.SportTypeId == league.SportTypeId).ToListAsync();
            return leagues;
        }

        public async Task<IEnumerable<League>> GetLeaguesBySportIdAsync(int SportTypeId)
        {
            var leagues = await _db.Leagues.Where(l=> l.SportTypeId == SportTypeId).ToListAsync();
            return leagues;
        }
    }
}
