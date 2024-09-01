using Manager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Models;
using AutoMapper;
using AutoMapper.Internal;

namespace RepositoryLayer.Repositories
{
    public class InterpreterRepository<TypedEntity, TEntity> : Repository<TEntity, long>, IRepostitory<TypedEntity, long>
         where TypedEntity : AbstractBO
         where TEntity : class, IEntity<long>, new()
    {
        public InterpreterRepository(IUnitOfWork unitOfWork, IMapper mapper)
               : base(unitOfWork, mapper)
        {
        }

       IList<TypedEntity> IRepostitory<TypedEntity, long>.GetAll()
       {
            var entities = base.GetAll();
            var bos = _mapper.Map<IList<TypedEntity>>(entities);
            for (int i = 0; i < entities.Count(); ++i)
                bos[i].Model = entities[i];

            return bos;
       }

        public void Insert(TypedEntity entity)
        {
            var entityToInsert = _mapper.Map<TEntity>(entity);
            base.Insert(entityToInsert);
            entity.Model = entityToInsert;
        }

        public void Delete(TypedEntity entity)
        {
            base.Delete(_mapper.Map<TEntity>(entity));
        }

        public void Delete(IEnumerable<TypedEntity> entities)
        {
            base.Delete(_mapper.Map<IEnumerable<TEntity>>(entities));
        }

        TypedEntity IRepostitory<TypedEntity, long>.GetById(long id)
        {
            var entity = base.GetById(id);
            if (entity == null)
                return null;

            var bo = _mapper.Map<TypedEntity>(entity);
            bo.Model = entity;

            return bo;
        }

        public void Update(TypedEntity entity, TypedEntity bo)
        {
            var propertiesToExclude = new List<string> { "Id", "AuthorId", "BookId", "PublisherId", "AuthorName", "PublisherName", "UserId" };
            UpdateEntityByNonNullProperties(entity.Model, bo, _mapper, propertiesToExclude);
            base.Update((TEntity)entity.Model);
            bo.Model = entity.Model;
        }

        private static U UpdateEntityByNonNullProperties<T, U>(
        U oldEntity,
        T changes,
        IMapper mapper,
        IList<string> propertiesToExclude)
        {
            var typeMap = mapper.ConfigurationProvider.Internal().ResolveTypeMap(changes.GetType(), oldEntity.GetType());

            // Iterate over properties of the changes object
            foreach (var property in changes.GetType().GetProperties())
            {
                // Find the corresponding property map in the type map
                var name = typeMap.PropertyMaps
                    .FirstOrDefault(p => p.SourceMember != null && p.SourceMember.Name == property.Name);

                if (name == null)
                    continue;

                // Get the corresponding property from the old entity
                var propertyOld = oldEntity.GetType().GetProperty(name.DestinationName);
                var newValue = property.GetValue(changes);

                // Exclude properties specified in the propertiesToExclude list
                if (propertyOld != null && !propertiesToExclude.Contains(propertyOld.Name))
                {
                    // Handle type mapping if needed
                    if (property.PropertyType != propertyOld.PropertyType)
                    {
                        var value = mapper.Map(newValue, property.PropertyType, propertyOld.PropertyType);
                        propertyOld.SetValue(oldEntity, value);
                    }
                    else
                    {
                        propertyOld.SetValue(oldEntity, newValue);
                    }
                }
            }

            return oldEntity;
        }

        public void Insert(IEnumerable<TypedEntity> entities)
        {
            base.Insert(_mapper.Map<IEnumerable<TEntity>>(entities));
        }

        IList<TypedEntity> IRepostitory<TypedEntity, long>.GetByIds(IEnumerable<long> ids)
        {
            var entities = base.GetByIds(ids);
            var bos = _mapper.Map<IList<TypedEntity>>(entities);
            for (int i = 0; i < entities.Count(); ++i)
                bos[i].Model = entities[i];

            return bos;
        }
    }
}
