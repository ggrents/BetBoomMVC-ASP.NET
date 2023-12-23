using BetBoomMVC.Application.Services;
using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Application.Services.Implementations;
using BetBoomMVC.Domain;
using BetBoomMVC.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace BetBoomMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
            builder.Services.AddScoped<ISportTypeService, SportTypeService>();
            builder.Services.AddScoped<ILeagueService, LeagueService>();
            builder.Services.AddScoped<IEventService, EventService>();
            builder.Services.AddScoped<IOutcomeService, OutcomeService>();
            builder.Services.AddScoped<IBetService, BetService>();

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