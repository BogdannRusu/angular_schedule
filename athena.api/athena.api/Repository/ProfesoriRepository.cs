using athena.api.Context;
using athena.api.Models;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace athena.api.Repository
{
    public class ProfesoriRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProfesoriRepository(AppDbContext appDbContext) { _appDbContext = appDbContext; }

        public async Task AddProfesoriAsync(Profesori profesori)
        {
            await _appDbContext.Set<Profesori>().AddAsync(profesori);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Profesori>> GetAllProfesoriAsync()
        {
            return await _appDbContext.Profesori.ToListAsync();
           
        }
    }
}
