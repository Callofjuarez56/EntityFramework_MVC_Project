using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.Groups
{
    public class GroupManager : IGroupManager
    {
        private readonly DataContext _dbContext;


        public GroupManager(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Group> AddGroup(CreateOrUpdateGroupRequest request)
        {
            var entity = new Storage.Entity.Group
            {
                id = Guid.NewGuid(),
                Name = request.Name,
                DepartmentNumber = request.DepartmentNumber

            };

            _dbContext.Groups.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;

        }

        public async Task<Group> UpdateGroup(Guid id, CreateOrUpdateGroupRequest request)
        {
            var entity = await _dbContext.Groups.FindAsync(request.id);
            entity.Name = request.Name;
            entity.DepartmentNumber = request.DepartmentNumber;
            await _dbContext.SaveChangesAsync();

            return entity;


        }

       public async Task DeleteGroup(Guid id)
        {
            var entity = await _dbContext.Groups.FindAsync(id);
            _dbContext.Groups.Remove(entity);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<Group> GetById(Guid id)
        {
            return await _dbContext.Groups.FirstOrDefaultAsync(g => g.id == id);
        }

        public async Task<IReadOnlyCollection<Group>> GetAll()
        {
            var query = _dbContext.Groups.AsNoTracking();
            var entities = await query.ToListAsync();
            return entities;

        }
    

    }
}
