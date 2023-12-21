using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.Services.Interfaces
{
    public interface ILeagueService
    {
        Task<IEnumerable<League>> GetLeaguesBySportIdAsync(int SportTypeId);
    }
}
