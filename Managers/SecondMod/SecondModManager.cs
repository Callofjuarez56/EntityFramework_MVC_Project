using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.SecondMod
{
    public class SecondModManager : ISecondModManager
    {
        private readonly DataContext _dbContext;


        public SecondModManager(DataContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<SecondM> AddSecondMod(CreateOrUpdateSecondMod request)
        {
            var entity = new SecondM
            {
                id = Guid.NewGuid(),
                SecondMd = request.SecondMd,

            };

            _dbContext.mod_sec.Add(entity);
            await _dbContext.SaveChangesAsync(); //сохранили все добавленные действия
            return entity; // вернули метод по добавлению 
        }

        public async Task DeleteSecondMod(Guid id)
        {
            var entity = await _dbContext.mod_sec.FindAsync(id);
            _dbContext.mod_sec.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<SecondM>> GetAll()
        {
            var query = _dbContext.mod_sec
                                  .AsNoTracking();
            var entities = await query.ToListAsync();
            return entities;
        }

        public async Task<SecondM> GetById(Guid id)
        {
            return await _dbContext.mod_sec.FirstOrDefaultAsync(g => g.id == id);
        }

        public async Task<SecondM> UpdateSecondMod(Guid id, CreateOrUpdateSecondMod request)
        {
            var entity = await _dbContext.mod_sec.FindAsync(request.id);
            entity.SecondMd = request.SecondMd;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

    }
}
