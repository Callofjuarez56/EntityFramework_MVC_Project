using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.Subjects
{
   public  interface ISubjectManager
    {
        Task<IReadOnlyCollection<Subject>> GetAll(); // получаем набор всех групп
        Task<Subject> AddSubj(CreateOrUpdateSubjRequest request);
        Task<Subject> UpdateSubj(Guid id, CreateOrUpdateSubjRequest request);

        Task DeleteSubj(Guid id);
        Task<Subject> GetById(Guid id);
    }
}
