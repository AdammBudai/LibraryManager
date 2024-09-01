using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataTransferObjects;
using LibraryManager.Models;

namespace BusinessLayer.Interfaces
{
    public interface IAuthorService : IManageService<AuthorDTO.Create,AuthorDTO.Update, AuthorBO>
    {
        bool CheckAccessibility(string name, string email);
    }
}
