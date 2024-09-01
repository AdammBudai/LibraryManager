using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Models;
using Manager.Helpers;

namespace RepositoryLayer.Interfaces
{
    public interface IAuthorRepository : IRepostitory<AuthorBO, long>, IInterpreterRepositoryTypedEntity<AuthorBO>
    {
        AuthorBO GetAuthorByName(string name);
        IEnumerable<AuthorBO> GetAuthorsByName(string name);
        IEnumerable<AuthorBO> GetAuthorsByEmail(string email);
    }
}
