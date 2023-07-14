using System;
using MagicVilla_API.Models;
using System.Linq.Expressions;

namespace MagicVilla_API.Repository.IRepository
{
	public interface IRepository<T> where T : class
	{
        // The model mapping with auto mapper is handled in api controller, repository directly commmunicate with entities, thats why we are using Villa not VillaDTO here
        //T is Villa model 

        Task<List<T>> GetAllAsync(Expression<Func<T,bool>>? filter = null);

        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true);

        Task CreateAsync(T entity);

        Task RemoveAsync(T entity);

        Task SaveAsync();
    }
}

