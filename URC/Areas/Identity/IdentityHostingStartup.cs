using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using URC.Areas.Identity.Data;
using URC.Data;

[assembly: HostingStartup(typeof(URC.Areas.Identity.IdentityHostingStartup))]
namespace URC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<UserRolesDB>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserRolesDBConnection")));

                //services.AddDefaultIdentity<URCUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddRoles<IdentityRole>();

            });
        }
    }
}