using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

namespace athena.api.Models.Data
{
    public class AthenaDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public AthenaDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("BogdanConnection")!;
            
        }
        public IDbConnection CreateConnection() => new SqlConnection(connectionString);

    }
}
