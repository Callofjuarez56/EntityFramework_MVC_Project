using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.Subjects
{
    public class SubjectManager : ISubjectManager
    {
        private readonly DataContext _dbContext;
      

        public SubjectManager(DataContext dbContext)
        {
            _dbContext = dbContext;
           
        }

        public async Task<Subject> AddSubj(CreateOrUpdateSubjRequest request)
        {
            var entity = new Subject
            {
                id = Guid.NewGuid(),
                Name_of_Sub = request.Name_of_Sub,
                
            };

            _dbContext.subj.Add(entity);
            await _dbContext.SaveChangesAsync(); //сохранили все добавленные действия
            return entity; // вернули метод по добавлению 
        }

        public async Task DeleteSubj(Guid id)
        {
            var entity = await _dbContext.subj.FindAsync(id);
            _dbContext.subj.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Subject>> GetAll()
        {
            var query = _dbContext.subj
                                  .AsNoTracking();
            var entities = await query.ToListAsync();
            return entities;
        }

        public async Task<Subject> GetById(Guid id)
        {
            return await _dbContext.subj.FirstOrDefaultAsync(g => g.id == id);
        }

        public async Task<Subject> UpdateSubj(Guid GroupId, CreateOrUpdateSubjRequest request)
        {
            var entity = await _dbContext.subj.FindAsync(request.id);
            entity.Name_of_Sub = request.Name_of_Sub;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
