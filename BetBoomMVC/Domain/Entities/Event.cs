namespace BetBoomMVC.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public DateTime Schedule { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
    }
}
