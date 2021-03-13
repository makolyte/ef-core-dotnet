using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace ef_core_cli.Context
{
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    public class DesignTimeContextFactory : IDesignTimeDbContextFactory<StreamingServiceContext>
    {
        public StreamingServiceContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Program>()
                .Build();


            var connectionString = config.GetConnectionString("Default");

            return new StreamingServiceContext(connectionString);
        }
    }
}
