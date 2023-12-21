using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Domain.Entities;
using BetBoomMVC.Domain;
using Microsoft.EntityFrameworkCore;

namespace BetBoomMVC.Application.Services.Implementations
{
    public class EventService : IEventService
    {
        private AppDbContext _db;
        public EventService(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Event>> GetEventsByLeagueIdAsync(int leagueId)
        {
            var events = await _db.Events.Where(l => l.LeagueId == leagueId).ToListAsync();
            return events;
        }
    }
}
