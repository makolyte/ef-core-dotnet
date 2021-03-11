using Microsoft.EntityFrameworkCore;

namespace ef_core_cli.Context
{
    public class StreamingServiceContext : DbContext
    {
        private readonly string ConnectionString;
        public StreamingServiceContext(string connectionString)
        {
            ConnectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
