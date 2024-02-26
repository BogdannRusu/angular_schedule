using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

namespace athena.api.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Profesori> Profitsori { get; set; }


        //private readonly IConfiguration _configuration;
        //private readonly string connectionString;

        //public AppDbContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //    connectionString = _configuration.GetConnectionString("BogdanConnection")!;
            
        //}
        //public IDbConnection CreateConnection() => new SqlConnection(connectionString);

    }
}
