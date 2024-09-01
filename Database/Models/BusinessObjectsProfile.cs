using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Models;
using AutoMapper;
using Database.Models;


namespace Database.Models
{
    public class BusinessObjectsProfile : Profile
    {
        public BusinessObjectsProfile()
        {
            CreateMap<Author, AuthorBO>();
            CreateMap<AuthorBO, Author>();
            CreateMap<Book, BookBO>();
            CreateMap<BookBO, Book>();
            CreateMap<Publisher, PublisherBO>();
            CreateMap<PublisherBO, Publisher>();
            CreateMap<User, UserBO>();
            CreateMap<UserBO, User>();
            CreateMap<BorrowingsBO, Borrowings>();
            CreateMap<Borrowings, BorrowingsBO>();
        }
    }
}
