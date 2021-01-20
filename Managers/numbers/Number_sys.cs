using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Managers.numbers
{
    public interface Number_sys
    {
        Task<cal_c> AddNumbers(CreateDrUpdateNumber request);
        Task<IReadOnlyCollection<cal_c>> GetAll();
        Task<cal_c> UpdateStudents(Guid GroupId, CreateDrUpdateNumber request);
        Task DeleteStudents(Guid id);
        Task<cal_c> GetById(Guid id);
    }
}
