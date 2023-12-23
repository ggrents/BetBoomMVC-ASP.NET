using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.ViewModels
{
    public class ProfileViewModel
    {
        public IEnumerable<Bet> Bets { get; set; }
    }
}
