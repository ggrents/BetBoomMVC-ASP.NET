using Microsoft.AspNetCore.Mvc;

namespace BetBoomMVC.Application.Services.Interfaces
{
    public interface IBetService
    {
        Task<bool> MakeBetAsync(int outcomeId, double amount);
    }
}
