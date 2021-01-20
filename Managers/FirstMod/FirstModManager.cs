using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.FirstMod
{
    public class FirstModManager : IFirstModManager
    {
        private readonly DataContext _dbContext;


        public FirstModManager(DataContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<FirstM> AddFirstMod(CreateOrUpdateFirstMod request)
        {
            var entity = new FirstM
            {
                id = Guid.NewGuid(),
                FirstMd = request.FirstMd,

            };

            _dbContext.mod_first.Add(entity);
            await _dbContext.SaveChangesAsync(); //сохранили все добавленные действия
            return entity; // вернули метод по добавлению 
        }

        public async Task DeleteFirstMod(Guid id)
        {
            var entity = await _dbContext.mod_first.FindAsync(id);
            _dbContext.mod_first.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<FirstM>> GetAll()
        {
            var query = _dbContext.mod_first
                                  .AsNoTracking();
            var entities = await query.ToListAsync();
            return entities;
        }

        public async Task<FirstM> GetById(Guid id)
        {
            return await _dbContext.mod_first.FirstOrDefaultAsync(g => g.id == id);
        }

        public async Task<FirstM> UpdateFirstMod(Guid id, CreateOrUpdateFirstMod request)
        {
            var entity = await _dbContext.mod_first.FindAsync(request.id);
            entity.FirstMd = request.FirstMd;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
