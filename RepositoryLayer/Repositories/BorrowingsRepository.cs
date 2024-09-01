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
    public class BorrowingsRepository : InterpreterRepository<BorrowingsBO, Borrowings>, IBorrowingsRepository
    {
        public BorrowingsRepository(IUnitOfWork unitOfWork, IMapper mapper)
           : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<BookBO> GetBorrowedBooksByUser(long userId)
        {
            var bookIds = Context.Set<Borrowings>().Where(b => b.UserId == userId).Select(b => b.BookId);
            var borrowedBooks = Context.Set<Book>().Where(b => bookIds.Contains(b.Id));
            return _mapper.Map<IEnumerable<BookBO>>(borrowedBooks);
        }

        public long GetBorrowingByBookId(long bookId)
        {
            var b = Context.Set<Borrowings>().Where(b => b.BookId == bookId).FirstOrDefault();
            return b.Id;
        }
    }
}
