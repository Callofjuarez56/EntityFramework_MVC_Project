using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.FirstMod
{
    public interface IFirstModManager
    {
        Task<IReadOnlyCollection<FirstM>> GetAll(); // получаем набор всех групп
        Task<FirstM> AddFirstMod(CreateOrUpdateFirstMod request);
        Task<FirstM> UpdateFirstMod(Guid id, CreateOrUpdateFirstMod request);

        Task DeleteFirstMod(Guid id);
        Task<FirstM> GetById(Guid id);
    }
}
