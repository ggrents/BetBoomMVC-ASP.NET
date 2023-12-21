using BetBoomMVC.Application.Services;
using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Application.Services.Implementations;
using BetBoomMVC.Domain;

namespace BetBoomMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddScoped<ISportTypeService, SportTypeService>();
            builder.Services.AddScoped<ILeagueService, LeagueService>();
            builder.Services.AddScoped<IEventService, EventService>();

            var app = builder.Build();

            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}