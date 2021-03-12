using System;

namespace ef_core_cli
{
    using Microsoft.Extensions.Configuration;

    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Program>()
                .Build();


            var connectionString = config.GetConnectionString("Default");

            Console.WriteLine(connectionString);
        }
    }
}
