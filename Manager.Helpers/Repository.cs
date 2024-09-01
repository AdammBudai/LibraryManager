using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Manager.Helpers;
using AutoMapper;


namespace Manager.Helpers
{
    public class Repository<TEntity, TKey> : IRepostitory<TEntity, TKey> where TEntity : class, IEntity<TKey>, new()
    {
        protected IMapper _mapper;
        public DbContext Context { get; set; }

        public Repository(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Context = unitOfWork.Context;
            _mapper = mapper;
        }

        private IList<TEntity> GetByIdsCore(IEnumerable<TKey> ids)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();
            return query.Where(e => ids.Contains(e.Id)).ToList();
        }

        private void DeleteCore(TEntity entity)
        {
            var local = Context.Set<TEntity>().Local.FirstOrDefault(e => e.Id.Equals(entity.Id));
            if (local != null)
            {
                Context.Entry(local).State = EntityState.Detached;
            }

            Context.Set<TEntity>().Remove(entity);
        }

        private void DeleteByIdCore(TKey id)
        {
            var entity = Context.Set<TEntity>().Local.SingleOrDefault(e => e.Id.Equals(id));

            if (entity == null)
            {
                entity = new TEntity { Id = id };
                Context.Set<TEntity>().Attach(entity);
            }

            DeleteCore(entity);
        }
        public IList<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }
        public TEntity GetById(TKey id)
        {
            return GetByIdsCore(new[] { id }).FirstOrDefault();
        }
        
        public IList<TEntity> GetByIds(IEnumerable<TKey> ids)
        {
            return GetByIdsCore(ids);
        }

        public void Insert(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities.ToList())
            {
                Insert(entity);
            }
        }

        public void Update(TEntity entity, TEntity bO)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            var local = Context.Set<TEntity>().Local.FirstOrDefault(entry => entry.Id.Equals(entity.Id));
            //var local = Context.Set<TEntity>().Find(entity.Id);
            if (local != null)
            {
                Context.Entry(local).State = EntityState.Detached;
            }

            Context.Set<TEntity>().Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            DeleteCore(entity);
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                DeleteCore(entity);
            }
        }

        public void Delete(TKey id)
        {
            DeleteByIdCore(id);
        }

        public void Delete(IEnumerable<TKey> ids)
        {
            foreach (var id in ids)
            {
                DeleteByIdCore(id);
            }
        }
    }
}
