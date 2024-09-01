using BusinessLayer.DataTransferObjects;
using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IPublisherService : IManageService<PublisherDTO.Create, PublisherDTO.Update, PublisherBO>
    {
        bool CheckExistingPublisherByName(string name);
        bool CheckExistingPublisherByEmail(string email);

    }
}
