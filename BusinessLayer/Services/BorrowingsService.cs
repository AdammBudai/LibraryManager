using AutoMapper;
using BusinessLayer.DataTransferObjects;
using BusinessLayer.Interfaces;
using LibraryManager.Models;
using Manager.Helpers;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class BorrowingsService : ManagerService<BorrowingsDTO.Create, BorrowingsDTO.Update, BorrowingsBO, IBorrowingsRepository>, IBorrowingsService
    {
        protected IBookService _bookService;
        protected IUserService _userService;
        public BorrowingsService(IUnitOfWork unitOfWork, IMapper mapper, IBorrowingsRepository repository, IBookService bookService,
            IUserService userService)
            : base(unitOfWork, mapper, repository)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _bookService = bookService;
            _userService = userService;
        }

        public override void Create(BorrowingsDTO.Create dto)
        {
            base.Create(dto);
        }
        public override void Update(long id, BorrowingsDTO.Update dto)
        {
            base.Update(id, dto);
        }

        public override BorrowingsBO Get(long id)
        {
            return base.Get(id);
        }
        public override void Delete(long id)
        {
            base.Delete(id);
        }

        public void Borrow(long bookId, long userId)
        {
            BorrowingsDTO.Create dto = new BorrowingsDTO.Create
            {
                BookId = bookId,
                UserId = userId,
                BorrowDate = DateTime.Now,
            };

            Create(dto);
            _bookService.Borrow(bookId);
            _unitOfWork.Commit();
        }

        public List<BookBO> GetBorrowedBooks(long userId)
        {
            return _repository.GetBorrowedBooksByUser(userId).ToList();
        }

        public void Return(long bookId)
        {
            _bookService.Return(bookId);
            long id = _repository.GetBorrowingByBookId(bookId);
            Delete(id);
            _unitOfWork.Commit();
        }
    }
}
