using Microsoft.AspNetCore.Identity;

namespace BetBoomMVC.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Bet> Bets { get; set; }
    }
}

