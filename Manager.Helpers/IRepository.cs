using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manager.Helpers
{
    public interface IRepostitory<TEntity, TKey>
    {
        DbContext Context { get; set; }

        IList<TEntity> GetAll();
   
        /// <summary>
        /// Deletes a specified entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes a specified entities
        /// </summary>
        /// <param name="entities"></param>
        void Delete(IEnumerable<TEntity> entities);


        /// <summary>
        /// Delete an entity by its id
        /// </summary>
        /// <param name="id"></param>
        void Delete(TKey id);

        /// <summary>
        /// Delete entities by their ids
        /// </summary>
        /// <param name="ids"></param>
        void Delete(IEnumerable<TKey> ids);

        /// <summary>
        /// Gets the entity by its id
        /// </summary>
        /// <param name="id"></param>
        TEntity GetById(TKey id);

        /// <summary>
        /// Gets the entities by their ids
        /// </summary>
        /// <param name="ids"></param>
        IList<TEntity> GetByIds(IEnumerable<TKey> ids);

        /// <summary>
        /// Inserts the specified entity into the table
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Inserts the specified entities into the table
        /// </summary>
        /// <param name="entities"></param>
        void Insert(IEnumerable<TEntity> entities);

        /// <summary>
        /// Updates the specified entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity, TEntity bO);

    }
}
