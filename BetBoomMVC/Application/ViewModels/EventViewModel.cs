using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.ViewModels
{
    public class EventViewModel
    {
        public League League { get; set; }
        public IEnumerable<League> Leagues { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}
