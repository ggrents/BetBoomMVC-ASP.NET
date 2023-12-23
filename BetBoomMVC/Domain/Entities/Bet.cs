namespace BetBoomMVC.Domain.Entities
{
    public class Bet
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public int OutcomeId { get; set; }
        public Outcome Outcome { get; set; }
        public ApplicationUser User { get; set; }
    }
}
