using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IManageService <DTO, UpdateDTO, BO>
    {
        void Create(DTO dto);
        void Delete(long id);
        void Update(long id, UpdateDTO dto);
        BO Get(long id);
        IEnumerable<BO> GetAll();
    }
}
