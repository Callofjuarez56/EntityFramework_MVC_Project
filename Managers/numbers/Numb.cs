using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.numbers
{
    public class Numb : Number_sys
    {
        private readonly DataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;

        public Numb(DataContext dbContext, IWebHostEnvironment hostEnvironment) 
        {
            _dbContext = dbContext;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<cal_c>  AddNumbers(CreateDrUpdateNumber request)
        {
            var entity = new cal_c
            {
                id = Guid.NewGuid(),
                FirstNumber = request.FirstNumber,
                SecondNumber = request.SecondNumber,
                GroupLeader = request.GroupLeader,
                GroupID = request.GroupID,
                SubjID = request.SubjID,
                FirstModID = request.FirstModID,
                SecondModID = request.SecondModID,
            };

            _dbContext.Cal_Cs.Add(entity);
            await _dbContext.SaveChangesAsync(); //сохранили все добавленные действия

            return entity; // вернули метод по добавлению студента
        }

        public async Task DeleteStudents(Guid id)
        {
            var entity = await _dbContext.Cal_Cs.FindAsync(id);
            _dbContext.Cal_Cs.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<cal_c>> GetAll()
        {
            var query = _dbContext.Cal_Cs
                                  .Include(st => st.Group)
                                  .OrderBy(st => st.SecondNumber)
                                  .AsNoTracking();
            var entities = await query.ToListAsync();

            return entities;
        }

        public async Task<cal_c> GetById(Guid id)
        {
            return await _dbContext.Cal_Cs.FirstOrDefaultAsync(g => g.id == id);
        }

        public async Task<cal_c> UpdateStudents(Guid GroupId, CreateDrUpdateNumber request)
        {
           var entity = await _dbContext.Cal_Cs.FindAsync(request.id);
            entity.FirstNumber = request.FirstNumber;
            entity.SecondNumber = request.SecondNumber;
            entity.GroupLeader = request.GroupLeader;
            entity.GroupID = request.GroupID;
            entity.SubjID = request.SubjID;
            entity.SecondModID = request.SecondModID;
            entity.FirstModID = request.FirstModID;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
