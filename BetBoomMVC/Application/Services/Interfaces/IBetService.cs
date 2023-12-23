using BetBoomMVC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BetBoomMVC.Application.Services.Interfaces
{
    public interface IBetService
    {
        Task<bool> MakeBetAsync(int outcomeId, double amount, ApplicationUser user);
        Task<IEnumerable<Bet>> GetBetsByUserAsync(ApplicationUser user);
    }
}
