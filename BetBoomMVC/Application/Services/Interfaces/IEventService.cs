using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.Services.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<Event>> GetEventsByLeagueIdAsync(int leagueId);
        Task<Event> GetEventByIdAsync(int eventId);
    }
}
