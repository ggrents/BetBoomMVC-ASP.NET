using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.Services.Interfaces
{
    public interface IOutcomeService
    {
        Task<IEnumerable<Outcome>> GetOutcomesByEventIdAsync(int eventId);
        Task<Outcome> GetOutcomeByIdAsync(int outcomeId);
    }
}
