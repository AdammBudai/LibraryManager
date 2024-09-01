using AutoMapper;
using BusinessLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Models;

namespace BusinessLayer.Services
{
    public class DataTransferObjectProfile : Profile
    {
       public DataTransferObjectProfile()
        {
            CreateMap<AuthorDTO, AuthorBO>();
            CreateMap<AuthorBO, AuthorDTO>();
            CreateMap<AuthorDTO.Create, AuthorBO>();
            CreateMap<AuthorDTO.Update, AuthorBO>();
            CreateMap<BookDTO, BookBO>();
            CreateMap<BookBO, BookBO>();
            CreateMap<BookDTO, BookBO>();
            CreateMap<BookBO, BookDTO>();
            CreateMap<BookDTO.Create, BookBO>();
            CreateMap<BookDTO.Update, BookBO>();
            CreateMap<PublisherDTO, PublisherBO>();
            CreateMap<PublisherBO, PublisherDTO>();
            CreateMap<PublisherBO, PublisherBO>();
            CreateMap<PublisherDTO.Create, PublisherBO>();
            CreateMap<PublisherDTO.Update, PublisherBO>();
            CreateMap<UserDTO, UserBO>();
            CreateMap<UserBO, UserBO>();
            CreateMap<UserDTO.Update, UserBO>();
            CreateMap<UserBO, UserDTO>();
            CreateMap<UserDTO.Create, UserBO>();
            CreateMap<UserDTO.Update, UserBO>();
            CreateMap<UserBO, UserDTO.Update>();
            CreateMap<UserDTO.Login, UserBO>();
            CreateMap<BorrowingsDTO, BorrowingsBO>();
            CreateMap<BorrowingsBO, BorrowingsDTO>();
            CreateMap<BorrowingsDTO.Create, BorrowingsBO>();
            CreateMap<BorrowingsDTO.Update, BorrowingsBO>();
       }

    }
}
