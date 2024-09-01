using LibraryManager.Models;
using Manager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IBorrowingsRepository : IRepostitory<BorrowingsBO, long>, IInterpreterRepositoryTypedEntity<BorrowingsBO>
    {
        IEnumerable<BookBO> GetBorrowedBooksByUser(long userId);
        long GetBorrowingByBookId(long bookId);
    }
}
