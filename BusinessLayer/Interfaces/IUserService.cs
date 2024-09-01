using BusinessLayer.DataTransferObjects;
using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IUserService : IManageService<UserDTO.Create, UserDTO.Update, UserBO>
    {
        void Register(UserDTO.Create dto);
        UserBO Login(UserDTO.Login dto);
        bool CheckName(string name);
        bool CheckEmail(string email);
        bool CheckLogin(string email, string password);
    }
}
