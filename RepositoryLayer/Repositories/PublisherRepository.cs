using AutoMapper;
using Manager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using RepositoryLayer.Interfaces;
using Database.Models;
using LibraryManager.Models;

namespace RepositoryLayer.Repositories
{
    public class PublisherRepository : InterpreterRepository<PublisherBO, Publisher>, IPublisherRepository
    {

        public PublisherRepository(IUnitOfWork unitOfWork, IMapper mapper)
           : base(unitOfWork, mapper)
        {
        }

        public PublisherBO GetPublisherByName(string name)
        {
            return _mapper.Map<PublisherBO>(Context.Set<Publisher>().Where(p => p.Name == name).FirstOrDefault());
        }

        public PublisherBO GetPublisherByEmail(string email)
        {
            return _mapper.Map<PublisherBO>(Context.Set<Publisher>().Where(p => p.Email == email).FirstOrDefault());
        }
    }
}
