using BusinessLayer.DataTransferObjects;
using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IBookService : IManageService<BookDTO.Create, BookDTO.Update, BookBO>
    {
        List<BookBO> GetAllAvailable();
        List<BookBO> GetBooksByAuthor(string authorName);
        List<BookBO> GetBooksByTitle(string publisherName);
        List<BookBO> GetBooksByAuthorAndTitle(string authorName, string title);
        void Borrow(long bookId);
        void Return(long bookId);
        bool CheckAccessibility(string title, string isbn);
    }
}
