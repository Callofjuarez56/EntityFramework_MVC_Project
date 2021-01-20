using WebApplication6.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication6.Managers.Groups
{
    public interface IGroupManager
    {
        Task<IReadOnlyCollection<Group>> GetAll(); // получаем набор всех групп
        Task<Group> AddGroup(CreateOrUpdateGroupRequest request);
        Task<Group> UpdateGroup(Guid id, CreateOrUpdateGroupRequest request);

        Task DeleteGroup(Guid id);
        Task<Group> GetById(Guid id);
    }
}
