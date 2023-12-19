namespace BetBoomMVC.Domain.Entities
{
    public class Outcome
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Status { get; set; } 
        public double Coefficient { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
