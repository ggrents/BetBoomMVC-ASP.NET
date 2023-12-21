using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.ViewModels
{
    public class SportDetailsViewModel
    {
        public SportType SportType { get; set; }
        public IEnumerable<League> Leagues { get; set; }
        public IEnumerable<SportType> SportTypes { get; set; }

    }
}
