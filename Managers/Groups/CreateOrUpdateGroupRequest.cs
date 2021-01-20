using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Managers.Groups
{
    public class CreateOrUpdateGroupRequest // используем для инициализации класса Group
    {  public Guid id { get; set; }

        public string Name { get; set; }

        public string DepartmentNumber { get; set; }
    }
}
