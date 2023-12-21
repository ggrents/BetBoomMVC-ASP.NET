using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.Services.Interfaces
{
    public interface ILeagueService
    {
        Task<IEnumerable<League>> GetLeaguesBySportIdAsync(int SportTypeId);
        Task<IEnumerable<League>> GetLeaguesByLeagueIdAsync(int LeagueId);
        Task<League> GetLeagueByIdAsync(int LeagueId);
    }
}
