using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataTransferObjects
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public class Create
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class Update
        {
            public string? Name { get; set; }
            public string? Email { get; set; }
        }

        public class Login
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
