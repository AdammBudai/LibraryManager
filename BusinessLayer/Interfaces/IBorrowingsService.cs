using BusinessLayer.DataTransferObjects;
using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IBorrowingsService : IManageService<BorrowingsDTO.Create, BorrowingsDTO.Update, BorrowingsBO>
    {
        void Borrow(long bookId, long userId);
        List<BookBO> GetBorrowedBooks(long userId);
        void Return(long bookId);
    }
}
