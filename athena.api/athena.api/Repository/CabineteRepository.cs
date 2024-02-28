using athena.api.Context;
using athena.api.Models;
using Microsoft.EntityFrameworkCore;

namespace athena.api.Repository
{
    public class CabineteRepository
    {
        private readonly AppDbContext _appDbContext;
        public CabineteRepository(AppDbContext appDbContext) { _appDbContext = appDbContext; }

        public async Task AddCabineteAsync(Cabinete cabinet)
        {
            await _appDbContext.Set<Cabinete>().AddAsync(cabinet);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Cabinete>> GetAllCabineteAsync()
        {
            return await _appDbContext.Cabinete.ToListAsync();

        }
    }
}
