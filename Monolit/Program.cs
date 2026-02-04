/*
    Copyright © 2026 Angle-Tolib, All Rights Reserved.
 */

using Microsoft.Extensions.Configuration;
using Monolit.Infrastructure;

namespace Monolit
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(builder.Environment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfiguration configuration = configurationBuilder.Build();
            AppConfig config = configuration.GetSection("Project").Get<AppConfig>()!;

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            await app.RunAsync();
        }
    }
}
