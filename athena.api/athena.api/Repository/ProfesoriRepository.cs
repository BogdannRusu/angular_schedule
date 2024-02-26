using athena.api.Models;
using athena.api.Models.Data;
using Microsoft.Identity.Client;

namespace athena.api.Repository
{
    public class ProfesoriRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProfesoriRepository(AppDbContext appDbContext) { _appDbContext = appDbContext; }

        public async Task AddProfesori(Profesori profesori)
        {
            await _appDbContext.Set<Profesori>().AddAsync(profesori);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
