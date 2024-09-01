using BusinessLayer.Interfaces;
using System;
using BusinessLayer.DataTransferObjects;
using LibraryManager.Models;
using RepositoryLayer.Interfaces;
using Manager.Helpers;
using AutoMapper;

namespace BusinessLayer.Services
{
    public class AuthorService : ManagerService<AuthorDTO.Create, AuthorDTO.Update, AuthorBO, IAuthorRepository>, IAuthorService
    {
        public AuthorService(IUnitOfWork unitOfWork, IMapper mapper, IAuthorRepository repository)
            :base(unitOfWork, mapper, repository)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public override  void Create(AuthorDTO.Create dto)
        {
             base.Create(dto);
        }
        public override void Update(long id, AuthorDTO.Update dto)
        {
           base.Update(id, dto);
        }

        public override AuthorBO Get(long id)
        {
            return base.Get(id);
        }
        public override void Delete(long id) {
            base.Delete(id);
        }

        public bool CheckAccessibility(string name, string email)
        {
            var authorsByName = _repository.GetAuthorsByName(name);
            var authorsByEmail = _repository.GetAuthorsByEmail(email);

            return authorsByName.Count() == 0 && authorsByEmail.Count() == 0;
        }
    }
}
