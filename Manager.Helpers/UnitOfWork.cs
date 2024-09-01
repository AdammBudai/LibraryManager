using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;


namespace Manager.Helpers
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        protected DbContext _context;
        private IDbContextTransaction _transaction;
        private bool isDisposed;
        
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public DbContext Context => _context;

        public void BeginTransaction()
        {
            if (_transaction != null)
                throw new Exception("Transaction has been running...");

            _transaction = Context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _transaction.Commit();
            _transaction.Dispose();
            _transaction = null;
        }

        public void RollbackTransaction()
        {
            _transaction.Rollback();
            _transaction.Dispose();
            _transaction = null;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                isDisposed = true;

                Context.Dispose();
            }
        }
    }
}
