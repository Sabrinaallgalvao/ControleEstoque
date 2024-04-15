using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Net;

public class AuthenticationOptions {
    public string? LoginPath { get; set; }
    public string? LogoutPath { get; set; }
    public string? CookieName { get; set; }
    public TimeSpan ExpirationTimeSpan { get; set; }
    public bool SlidingExpiration { get; set; }
}


public class Program { 
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
             {
                 options.LoginPath = "/login";
                 options.LogoutPath = "/logout";
                 options.Cookie.Name = ".ASP.NET.FormsAuthentication";
                 options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                 options.SlidingExpiration = true;
             });
        // Configure the HTTP request pipeline.
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



    

