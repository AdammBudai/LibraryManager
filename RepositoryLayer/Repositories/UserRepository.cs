using AutoMapper;
using Database.Models;
using LibraryManager.Models;
using Manager.Helpers;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class UserRepository : InterpreterRepository<UserBO, User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork, IMapper mapper)
           : base(unitOfWork, mapper)
        {
        }

        public UserBO GetByName(string name)
        {
           var query = Context.Set<User>().Where(u => u.Name == name).FirstOrDefault();
            return _mapper.Map<UserBO>(query);
        }

        public UserBO GetByEmail(string email)
        {
            var query = Context.Set<User>().Where(u => u.Email == email).FirstOrDefault();
            return _mapper.Map<UserBO>(query);
        }
    }
}
