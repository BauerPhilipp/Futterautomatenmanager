using Futterautomatenmanager.Components;
using Futterautomatenmanager.Components.Account;
using Futterautomatenmanager.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FutterautomatenDatenbank.Context;
using FutterautomatenDatenbank.Models;

namespace Futterautomatenmanager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Kontainer für DI elemente
            var builder = WebApplication.CreateBuilder(args);

            //.AddInteractiveServerComponents() ermöglicht Interactivität mit dem Server über SignalR
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            //Notwendig für die Authentifizierung
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddScoped<IdentityUserAccessor>();
            builder.Services.AddScoped<IdentityRedirectManager>();
            builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
            builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();


            builder.Services.AddAuthentication(options =>
                {
                    options.DefaultScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                })
                .AddIdentityCookies();


            //abgreifen des Connectionstrings aus appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();

            //Für die FutterautomatController API
            builder.Services.AddControllers();

            //FutterautomatenDatenbankspeicherort und das Interface beim Servise registrieren. 
            builder.Services.AddDbContextFactory<FutterautomatenContext>(options => options.UseSqlite(
                builder.Configuration.GetConnectionString("FutterautomatenDatenbankConnection")));
            builder.Services.AddTransient<IFutterautomatenEFCoreRepository, FutterautomatenEFCoreRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            //.AddInteractiveServerRenderMode() ermöglicht Interactivität mit dem Server über SignalR
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            //Für die FutterautomatController API
            app.MapControllers();

            // Add additional endpoints required by the Identity /Account Razor components.
            app.MapAdditionalIdentityEndpoints();

            app.Run();
        }
    }
}
