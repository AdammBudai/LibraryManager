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
    public class BookService : ManagerService<BookDTO.Create, BookDTO.Update, BookBO, IBookRepository>, IBookService
    {
        protected IAuthorRepository _authorRepository;
        protected IPublisherRepository _publisherRepository;
        public BookService(IUnitOfWork unitOfWork, IMapper mapper, IBookRepository repository,
            IAuthorRepository authorRepository, IPublisherRepository publisherRepository)
            : base(unitOfWork, mapper, repository)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _authorRepository = authorRepository;
            _publisherRepository = publisherRepository;
        }

        public override void Create(BookDTO.Create dto)
        {
            var author = _authorRepository.GetAuthorByName(dto.AuthorName);
            if (author == null)
            {
               throw new Exception("Author not found");
            }
            var publisher = _publisherRepository.GetPublisherByName(dto.PublisherName);
            if (publisher == null)
            {
                throw new Exception("Publisher not found");
            }

            dto.AuthorId = author.Id;
            dto.PublisherId = publisher.Id;
            dto.PublishDate = DateTime.Now;
            base.Create(dto);
        }
        public override void Update(long id,BookDTO.Update dto)
        {
            base.Update(id, dto);
        }

        public override BookBO Get(long id)
        {
            return base.Get(id);
        }
        public override void Delete(long id)
        {
            base.Delete(id);
        }

        public List<BookBO> GetAllAvailable()
        {
            return _mapper.Map<List<BookBO>>(_repository.GetAllAvailable());
        }

        public List<BookBO> GetBooksByAuthor(string authorName)
        {
            return _repository.GetBooksByAuthor(authorName).ToList();
        }

        public List<BookBO> GetBooksByTitle(string title)
        {
            return _repository.GetBooksByTitle(title).ToList();
        }

        public List<BookBO> GetBooksByAuthorAndTitle(string authorName, string title)
        {
            return _repository.GetByAuthorAndTitle(authorName, title).ToList();
        }

        public void Borrow(long bookId)
        {
            var book =  _mapper.Map<BookDTO>(_repository.GetById(bookId));

            BookDTO.Update dto = new BookDTO.Update
            {
                Title = book.Title,
                ISBN = book.ISBN,
                PublishDate = book.PublishDate,
                Available = false
            };

            Update(bookId, dto);
            _unitOfWork.Commit();
        }

        public void Return(long bookId)
        {
            var book = _mapper.Map<BookDTO>(_repository.GetById(bookId));

            BookDTO.Update dto = new BookDTO.Update
            {
                Title = book.Title,
                ISBN = book.ISBN,
                PublishDate = book.PublishDate,
                Available = true
            };

            Update(bookId, dto);
            _unitOfWork.Commit();
        }

        public bool CheckAccessibility(string title, string isbn)
        {
            var booksByTitle = _repository.GetBooksByTitle(title);
            var booksByIsbn = _repository.GetBooksByIsbn(isbn);

            return booksByTitle.Count() == 0 && booksByIsbn.Count() == 0;
        }
    }
}
