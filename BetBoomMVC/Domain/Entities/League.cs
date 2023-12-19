namespace BetBoomMVC.Domain.Entities
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int SportTypeId { get; set; }
        public SportType SportType { get; set; }
    }
}
