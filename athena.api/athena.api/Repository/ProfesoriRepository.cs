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

        public async Task<Profesori>GetProfesoriById(int id)
        {
            return await _appDbContext.Profesori.FindAsync(id);
        }

        public async Task UpdateProfesori(int id, Profesori model)
        {
            var profesor = await _appDbContext.Profesori.FindAsync(id);
            if(profesor == null)
            {
                throw new Exception("Profesorul nu a fost gasit");
            }
            profesor.id_prof = model.id_prof;
            profesor.Nume = model.Nume;
            profesor.Prenume = model.Prenume;
            profesor.Patronimic = model.Patronimic;
            profesor.data_activarii = model.data_activarii;
            profesor.end_data_activarii = model.end_data_activarii;
            profesor.Functia = model.Functia;
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteProfesorAsync(int id)
        {
            var prof = await _appDbContext.Profesori.FindAsync(id);
            if(prof == null)
            {
                throw new Exception("Profesorul nu a fost gasit");
            }
            _appDbContext.Profesori.Remove(prof);
            _appDbContext.SaveChangesAsync();
        }
    }
}
