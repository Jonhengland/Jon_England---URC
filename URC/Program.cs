/*
Author: Peter Forsling
Date: 12 October 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the Program to run the site
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using URC.Areas.Identity.Data;

namespace URC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            CreateDbIfNotExists(host);
            host.Run();
        }

        /// <summary>
        /// Creates the Database Context if it does not exist already
        /// </summary>
        /// <param name="host">The host</param>
        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var urcContext = services.GetRequiredService<Data.URCContext>();
                    //context.Database.EnsureCreated();
                    Data.DbInitializer.Initialize(urcContext);

                    var userManager = services.GetRequiredService<UserManager<URCUser>>();
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    var userRolesContext = services.GetRequiredService<Data.UserRolesDB>();
                    Data.SeedUserRolesDB.Seed(userManager, roleManager);

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
