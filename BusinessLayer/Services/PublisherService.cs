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
    public class PublisherService : ManagerService<PublisherDTO.Create, PublisherDTO.Update, PublisherBO, IPublisherRepository>, IPublisherService
    {
        public PublisherService(IUnitOfWork unitOfWork, IMapper mapper, IPublisherRepository repository)
            : base(unitOfWork, mapper, repository)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public override void Create(PublisherDTO.Create dto)
        {
            base.Create(dto);
        }
        public override void Update(long id, PublisherDTO.Update dto)
        {
            base.Update(id, dto);
        }

        public override PublisherBO Get(long id)
        {
            return base.Get(id);
        }
        public override void Delete(long id)
        {
            base.Delete(id);
        }

        public bool CheckExistingPublisherByName(string name)
        {
            if (_repository.GetPublisherByName(name) == null)
            {
                return true;
            }
            return false;
        }

        public bool CheckExistingPublisherByEmail(string email)
        {
            if (_repository.GetPublisherByEmail(email) == null)
            {
                return true;
            }
            return false;
        }
    }
}
