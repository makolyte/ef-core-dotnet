using System;
using ef_core_cli.Context;
using ef_core_cli.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ef_core_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Program>()
                .Build();


            using (var context = new StreamingServiceContext(config.GetConnectionString("Default")))
            {
                context.Database.Migrate();

                context.Add(new Movie 
                { 
                   Name = "John Wick",
                   Description = "A revenge-seeking assassin goes after EVERYONE",
                   ReleaseYear = 2014,
                   RuntimeMinutes = 101
                });
                context.SaveChanges();
            }
        }
    }
}
