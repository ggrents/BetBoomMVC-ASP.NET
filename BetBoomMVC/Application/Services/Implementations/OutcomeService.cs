using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Domain;
using BetBoomMVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BetBoomMVC.Application.Services.Implementations
{
    public class OutcomeService : IOutcomeService
    {
        private readonly AppDbContext _db;
        public OutcomeService(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Outcome>> GetOutcomesByEventIdAsync(int eventId)
        {
            var outcomes = await _db.Outcomes.Where(o => o.EventId == eventId).ToListAsync();

            return outcomes;
        }

        public async Task<Outcome> GetOutcomeByIdAsync(int outcomeId)
        {
            var outcome = await _db.Outcomes.FirstOrDefaultAsync(o=>o.Id ==  outcomeId);
            return outcome;
        }
    }
}
