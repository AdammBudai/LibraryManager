using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Models;
using Manager.Helpers;

namespace RepositoryLayer.Interfaces
{
   public interface IBookRepository : IRepostitory<BookBO, long>, IInterpreterRepositoryTypedEntity<BookBO>
   {
        IEnumerable<BookBO> GetBooksByAuthor(long authorId);
        IEnumerable<BookBO> GetBooksByAuthor(string authorName);
        IEnumerable<BookBO> GetBooksByPublisher(long publisherId);
        IEnumerable<BookBO> GetBooksByTitle(string title);
        IEnumerable<BookBO> GetBooksByIsbn(string isbn);
        IEnumerable<BookBO> GetAllAvailable();
        IEnumerable<BookBO> GetByAuthorAndTitle(string authorName, string title);
   }
}
