using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Interfaces;
using Database.Models;
using AutoMapper;
using Manager.Helpers;

namespace RepositoryLayer.Repositories
{
    public class AuthorRepository : InterpreterRepository<AuthorBO, Author>, IAuthorRepository
    {
        public AuthorRepository(IUnitOfWork unitOfWork, IMapper mapper)
           : base(unitOfWork, mapper)
        {
        }

        public AuthorBO GetAuthorByName(string name)
        {
            return _mapper.Map<AuthorBO>(Context.Set<Author>().Where(x => x.Name == name).FirstOrDefault());
        }

        public IEnumerable<AuthorBO> GetAuthorsByName(string name)
        {
            return _mapper.Map<IEnumerable<AuthorBO>>(Context.Set<Author>().Where(x => x.Name == name));
        }
        public IEnumerable<AuthorBO> GetAuthorsByEmail(string email)
        {
            return _mapper.Map<IEnumerable<AuthorBO>>(Context.Set<Author>().Where(x => x.Email == email));
        }
    }
}
