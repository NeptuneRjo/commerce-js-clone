﻿using System.Linq.Expressions;


namespace CommerceApi.BLL.Services
{
    public interface IGenericService<TEntity>
    {
        /// <summary>
        /// Retrieve an entity by a query expression.
        /// <br />
        /// Include any child references.
        /// <br />
        /// Add a destination type to map the result.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <param name="destinationType"></param>
        /// <returns>The found <see cref="TEntity"/>, mapped if destination is included. </returns>
        Task<object> GetEntityAsync(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, object>>[]? includes = null, Type? destinationType = null);

        /// <summary>
        /// Retrieve a collection of entities.
        /// <br />
        /// Include the destination type to map the entities.
        /// </summary>
        /// <param name="destinationType"></param>
        /// <returns>The collection of found <see cref="TEntity"/>, mapped if destination is included</returns>
        Task<object> GetEntitiesAsync(Type? destinationType = null);

        /// <summary>
        /// Delete the first entity found by the query.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task DeleteEntityAsync(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Add an entity and return the result.
        /// <br />
        /// Include destination type to map the result.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="destinationType"></param>
        /// <returns>The added <see cref="TEntity"/>, mapped if destination type is included</returns>
        Task<object> AddEntityAsync(TEntity entity, Type? destinationType = null);

        /// <summary>
        /// Update the entity
        /// <br />
        /// Include the destination type to map the result
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="destinationType"></param>
        /// <returns>The updated <see cref="TEntity"/>, mapped if destination type is included.</returns>
        Task<object> UpdateEntityAsync(TEntity entity, Type? destinationType = null);
    }
}
