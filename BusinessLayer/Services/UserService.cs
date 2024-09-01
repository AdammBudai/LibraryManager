using AutoMapper;
using BusinessLayer.DataTransferObjects;
using BusinessLayer.Interfaces;
using LibraryManager.Models;
using Manager.Helpers;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService : ManagerService<UserDTO.Create, UserDTO.Update, UserBO, IUserRepository>, IUserService
    {
        protected IBookService _bookService;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IUserRepository repository, IBookService bookService)
            : base(unitOfWork, mapper, repository)
        {
            _bookService = bookService;
        }

        public override void Create(UserDTO.Create dto)
        {
            base.Create(dto);
        }
        public override void Update(long id, UserDTO.Update dto)
        {
            
           base.Update(id, dto);
        }

        public override UserBO Get(long id)
        {
            return base.Get(id);
        }
        public override void Delete(long id)
        {
            base.Delete(id);
        }

        public void Register(UserDTO.Create dto)
        {
            Create(dto);
            _unitOfWork.Commit();
        }

        public UserBO Login(UserDTO.Login dto)
        {
            var user = _repository.GetByEmail(dto.Email);
            return user;
        }

        public bool CheckName(string name)
        {
            if (_repository.GetByName(name) == null)
            {
                return true;
            }
            return false;
        }

        public bool CheckEmail(string email)
        {
            if (_repository.GetByEmail(email) == null)
            {
                return true;

            }
            return false;
        }

        public bool CheckLogin(string email, string password)
        {
            var user = _repository.GetByEmail(email);
            if (user == null)
            {
                return false;
            }
            if (user.Password == password)
            {
                return true;
            }
            return false;
        }


    }
}
