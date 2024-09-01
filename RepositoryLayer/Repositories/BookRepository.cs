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
    public class BookRepository : InterpreterRepository<BookBO, Book>, IBookRepository
    {
        public BookRepository(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<BookBO> GetBooksByAuthor(long authorId)
        {
            return _mapper.Map<IEnumerable<BookBO>>(Context.Set<Book>().Where(b => b.AuthorId == authorId));
        }

        public IEnumerable<BookBO> GetBooksByPublisher(long publisherId)
        {
            return _mapper.Map<IEnumerable<BookBO>>(Context.Set<Book>().Where(b => b.PublisherId == publisherId));
        }

        public IEnumerable<BookBO> GetAllEntities()
        {
            return _mapper.Map<IEnumerable<BookBO>>(Context.Set<Book>());
        }
        public BookBO GetBookByTitle(string title)
        {
            return _mapper.Map<BookBO>(Context.Set<Book>().Where(b => b.Title == title));
        }

        public IEnumerable<BookBO> GetAllAvailable()
        {
            return _mapper.Map<IEnumerable<BookBO>>(Context.Set<Book>().Where(b => b.Available == true));
        }

        public IEnumerable<BookBO> GetBooksByAuthor(string authorName)
        {
            return _mapper.Map<IEnumerable<BookBO>>(Context.Set<Book>().Where(b => b.AuthorName == authorName));
        }
        public IEnumerable<BookBO> GetBooksByTitle(string title)
        {
            return _mapper.Map<IEnumerable<BookBO>>(Context.Set<Book>().Where(b => b.Title == title));
        }

        public IEnumerable<BookBO> GetBooksByIsbn(string isbn)
        {
            return _mapper.Map<IEnumerable<BookBO>>(Context.Set<Book>().Where(b => b.ISBN == isbn));
        }

        public IEnumerable<BookBO> GetByAuthorAndTitle(string authorName, string title)
        {
            return _mapper.Map<IEnumerable<BookBO>>(Context.Set<Book>().Where(b => b.AuthorName == authorName && b.Title == title));
        }
    }
}
