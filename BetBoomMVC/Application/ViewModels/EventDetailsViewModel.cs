using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.ViewModels
{
    public class EventDetailsViewModel
    {
        public Event Event { get; set; }
        public IEnumerable<League> Leagues { get; set; }
        public IEnumerable<Outcome> Outcomes { get; set; }

    }
}
