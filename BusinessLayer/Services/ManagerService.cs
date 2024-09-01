using AutoMapper;
using BusinessLayer.Interfaces;
using LibraryManager.Models;
using Manager.Helpers;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public abstract class ManagerService<DTO, UpdateDTO, BO, Repository> : BaseService, IManageService<DTO, UpdateDTO, BO>
        where DTO:class
        where BO : AbstractBO
        where Repository : IRepostitory<BO, long>, IInterpreterRepositoryTypedEntity<BO>
    {
        protected Repository _repository;

        public ManagerService(IUnitOfWork unitOfWork, IMapper mapper, Repository repository)
            : base(unitOfWork, mapper)
        {
            _repository = repository;
        }

        public virtual void Create(DTO dto)
        {
            var bo = _mapper.Map<BO>(dto);
            _repository.Insert(bo);
            _unitOfWork.Commit();
        }

        public virtual void Delete(long id)
        {
            _repository.Delete(id);
            _unitOfWork.Commit();
        }

        public virtual BO Get(long id)
        {
            var bo = _repository.GetById(id);
            return _mapper.Map<BO>(bo);
        }

        public virtual IEnumerable<BO> GetAll()
        {
            var bo = _repository.GetAll();
            return _mapper.Map<IEnumerable<BO>>(bo);
        }

        public virtual void Update(long id, UpdateDTO update)
        {

            var existingEntity = _repository.GetById(id); 
            if (existingEntity == null)
            {
                throw new ArgumentException("Entity not found");
            }

            _repository.Update(existingEntity,_mapper.Map<BO>(update)); 
            _unitOfWork.Commit();
        }

    }
}
