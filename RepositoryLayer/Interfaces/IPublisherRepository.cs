using LibraryManager.Models;
using Manager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IPublisherRepository : IRepostitory<PublisherBO, long>, IInterpreterRepositoryTypedEntity<PublisherBO>
    {
        public PublisherBO GetPublisherByName(string name);
        public PublisherBO GetPublisherByEmail(string email);
    }
}
