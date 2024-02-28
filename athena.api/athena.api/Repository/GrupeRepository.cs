using athena.api.Context;
using athena.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace athena.api.Repository
{
    public class GrupeRepository
    {
        private readonly AppDbContext _appDbContext;
        public GrupeRepository(AppDbContext appDbContext) { _appDbContext = appDbContext; }

        public async Task AddGrupeAsync(Grupe cabinet)
        {
            await _appDbContext.Set<Grupe>().AddAsync(cabinet);
            await _appDbContext.SaveChangesAsync();
        }
        public async Task<List<Grupe>> GetAllGrupaAsync()
        {
            return await _appDbContext.Grupe.ToListAsync();
        }
    }
}
