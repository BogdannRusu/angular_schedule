using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace athena.api.Models.Data
{
    public class AthenaDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public AthenaDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection")!;
            
        }
        public IDbConnection CreateConnection() => new SqlConnection(connectionString);

    }
}
