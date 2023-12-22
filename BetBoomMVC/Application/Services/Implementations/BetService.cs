using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Domain;
using BetBoomMVC.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BetBoomMVC.Application.Services.Implementations
{
    public class BetService : IBetService
    {
        private readonly AppDbContext _db;
        public BetService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<bool> MakeBetAsync(int outcomeId, double amount)
        {
            if (outcomeId <= 0 || amount <= 0)
            {
                return false;
            }

            Bet bet = new Bet
            {
                OutcomeId = outcomeId,
                Amount = amount
            };

            await _db.Bets.AddAsync(bet);
            var isSaved = await _db.SaveChangesAsync();
            return isSaved == 1 ;
        }


    }
}
