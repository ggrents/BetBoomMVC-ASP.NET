using Microsoft.EntityFrameworkCore;
using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Outcome> Outcomes { get; set; }
        public DbSet<SportType> SportTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=bbMVC;Trusted_Connection=True;TrustServerCertificate=true;");
        }

    }
}
