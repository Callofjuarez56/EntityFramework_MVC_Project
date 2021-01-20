using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.SecondMod
{
    public interface ISecondModManager
    {
        Task<IReadOnlyCollection<SecondM>> GetAll(); // получаем набор всех групп
        Task<SecondM> AddSecondMod(CreateOrUpdateSecondMod request);
        Task<SecondM> UpdateSecondMod(Guid id, CreateOrUpdateSecondMod request);

        Task DeleteSecondMod(Guid id);
        Task<SecondM> GetById(Guid id);

    }
}
