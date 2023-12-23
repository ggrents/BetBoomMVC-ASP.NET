using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Domain;
using BetBoomMVC.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BetBoomMVC.Application.Services.Implementations
{
    public class BetService : IBetService
    {
        private readonly AppDbContext _db;
        public BetService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Bet>> GetBetsByUserAsync(ApplicationUser user)
        {
            var bets = await _db.Bets.Where(bets => bets.User == user).Include(b => b.Outcome).ThenInclude(o => o.Event).ToListAsync();
            return bets;
        }

        public async Task<bool> MakeBetAsync(int outcomeId, double amount, ApplicationUser user)
        {
            if (outcomeId <= 0 || amount <= 0)
            {
                return false;
            }

            Bet bet = new Bet
            {
                OutcomeId = outcomeId,
                Amount = amount,
                User = user
            };

            await _db.Bets.AddAsync(bet);
            var isSaved = await _db.SaveChangesAsync();
            return isSaved == 1 ;
        }


    }
}
