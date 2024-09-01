using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Helpers
{
    public interface IUnitOfWork
    {
        DbContext Context { get; }
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        //string GetDatabaseName();
        void Commit();
    }
}
