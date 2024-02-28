using athena.api.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

namespace athena.api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Profesori> Profesori { get; set; }
        public DbSet<Cabinete> Cabinete { get; set; }
        public DbSet<Grupe> Grupe { get; set; }


    }
}
